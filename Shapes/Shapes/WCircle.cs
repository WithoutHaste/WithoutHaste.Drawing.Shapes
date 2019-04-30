using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// A circle shape. Immutable.
	/// </summary>
	public class WCircle : WShape, IDraw//, IClosedFigure
	{
		/// <summary></summary>
		public static readonly int DEGREES_IN_CIRCLE = 360;
		/// <summary></summary>
		public static readonly int DEGREES_IN_HALF_CIRCLE = 180;
		/// <summary></summary>
		public static readonly double RADIANS_90DEGREES = Math.PI / 2;
		/// <summary></summary>
		public static readonly double RADIANS_180DEGREES = Math.PI;
		/// <summary></summary>
		public static readonly double RADIANS_270DEGREES = 3 * Math.PI / 2;
		/// <summary></summary>
		public static readonly double RADIANS_360DEGREES = 2 * Math.PI;

		/// <summary>Center x coordinate.</summary>
		public readonly double X;
		/// <summary>Center y coordinate.</summary>
		public readonly double Y;
		/// <summary></summary>
		public readonly double Radius;

		/// <summary></summary>
		public WPoint Center { get { return new WPoint(X, Y); } }
		/// <summary></summary>
		public double Diameter { get { return 2 * Radius; } }
		/// <inheritdoc/>
		public double MaxX { get { return X + Radius; } }
		/// <inheritdoc/>
		public double MaxY { get { return Y + Radius; } }

		/// <summary>Based on coordinate plane, which degree points towards the MaxX coordinate?</summary>
		public double MaxXDegrees {
			get {
				switch(Geometry.CoordinatePlane)
				{
					case Geometry.CoordinatePlanes.Screen: return 0;
					case Geometry.CoordinatePlanes.Paper: return 0;
					default: throw new NotImplementedException("Coordinate plane not supported.");
				}
			}
		}
		/// <summary>Based on coordinate plane, which degree points towards the MaxY coordinate?</summary>
		public double MaxYDegrees {
			get {
				switch(Geometry.CoordinatePlane)
				{
					case Geometry.CoordinatePlanes.Screen: return 90;
					case Geometry.CoordinatePlanes.Paper: return 270;
					default: throw new NotImplementedException("Coordinate plane not supported.");
				}
			}
		}

		/// <summary></summary>
		public WCircle(double x, double y, double radius)
		{
			X = x;
			Y = y;
			Radius = radius;
		}

		/// <summary></summary>
		public WCircle(WPoint center, double radius)
		{
			X = center.X;
			Y = center.Y;
			Radius = radius;
		}

		/// <summary>Finds the intersection points between the edge of this circle and circle <paramref name='b'/>.</summary>
		/// <returns>Null (no intersection), an array of length 1, or an array of length 2.</returns>
		public WPoint[] GetIntersectionPoints(WCircle b)
		{
			//following the method in math/intersectionCircleCircle.png

			WCircle a = this;
			double d = a.Center.Distance(b.Center); //distance between centers
			if(d > a.Radius + b.Radius)
			{
				return null; //circles too far apart to intersect
			}
			if(a.ContainsOrIsContained(b))
			{
				return null; //one circle is wholly inside the other
			}

			//the radical line is the line between the two intersecting points of the circles
			//Point c is the center of the radical line, which is also on the line between the centers
			double dA = (Math.Pow(a.Radius, 2) - Math.Pow(b.Radius, 2) + Math.Pow(d, 2)) / (2 * d); //distance from centerA to pointC
			if(dA == a.Radius)
			{
				return new WPoint[] { Geometry.PointOnLine(a.Center, b.Center, a.Radius) }; //circles intersect at single point
			}
			WPoint c = a.Center + dA * (b.Center - a.Center) / d;

			//h is the distance from pointC to either intersection point (the hypotenus of triangle centerA-C-intersection)
			double h = Math.Sqrt(Math.Pow(a.Radius, 2) - Math.Pow(dA, 2));

			return new WPoint[] {
				new WPoint(c.X + (h * (b.Y - a.Y) / d), c.Y - h * (b.X - a.X) / d),
				new WPoint(c.X - (h * (b.Y - a.Y) / d), c.Y + h * (b.X - a.X) / d)
			};
		}

		/// <summary>
		/// Find the two tangent points on the circle that form lines to point <paramref name='b'/>.
		/// </summary>
		/// <returns>Array of length 2.</returns>
		public WPoint[] GetTangentPoints(WPoint b)
		{
			//point C and D are the tangents
			WCircle a = this;
			double distanceAB = a.Center.Distance(b);
			double degreesAB = DegreesAtPoint(b);
			double degreesAB_AC = Math.Cos(Radius / distanceAB);
			WPoint c = PointAtDegrees(degreesAB + degreesAB_AC);
			WPoint d = PointAtDegrees(degreesAB - degreesAB_AC);
			return new WPoint[] { c, d };
		}

		/// <summary>
		/// Returns true if any part of this circle overlaps any part of circle <paramref name='b'/>.
		/// </summary>
		public bool Overlaps(WCircle b)
		{
			WPoint[] intersections = this.GetIntersectionPoints(b);
			if(intersections != null)
				return true;
			return this.ContainsOrIsContained(b);
		}

		/// <summary>
		/// Returns true if any part of this circle overlaps any part of line segment <paramref name='b'/>.
		/// </summary>
		/// <remarks>
		/// If line <paramref name='b'/> lies within the circle, that counts as overlapping.
		/// </remarks>
		public bool Overlaps(WLineSegment b)
		{
			WPoint[] lineIntersectionPoints = GetIntersectionPoints(b.ToWLine());
			if(lineIntersectionPoints == null)
				return false;
			foreach(WPoint point in lineIntersectionPoints)
			{
				if(b.Overlaps(point))
					return true;
			}
			if(lineIntersectionPoints.Length == 2)
			{
				//if b lies entirely within the circle
				WLineSegment intersectionLine = new WLineSegment(lineIntersectionPoints[0], lineIntersectionPoints[1]);
				if(intersectionLine.Length > b.Length && intersectionLine.Overlaps(b))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Returns true if this circle entirely contains circle <paramref name='b'/>, or <paramref name='b'/> entirely contains this circle, or they exactly overlap.
		/// </summary>
		public bool ContainsOrIsContained(WCircle b)
		{
			if(this.Radius > b.Radius)
				return this.Contains(b);
			return b.Contains(this);
		}

		/// <summary>
		/// Returns true if this circle entirely contains circle <paramref name='b'/>, or they exactly overlap.
		/// </summary>
		public bool Contains(WCircle b)
		{
			if(b.Radius > this.Radius)
				return false;
			if(b.Radius == this.Radius)
				return (b.Center == this.Center);
			double d = this.Center.Distance(b.Center);
			return (this.Radius >= d + b.Radius);
		}

		/// <summary>
		/// Returns true if this circle entirely contains wedge <paramref name='b'/>.
		/// </summary>
		public bool Contains(WWedge b)
		{
			foreach(WPoint point in b.FourPoints)
			{
				if(!Contains(point))
					return false;
			}
			return true;
		}

		/// <summary>
		/// Returns true if point <paramref name='b'/> lies within or on this circle.
		/// </summary>
		public bool Contains(WPoint b)
		{
			return (Center.Distance(b) <= Radius);
		}

		/// <summary>
		/// Returns the point on this circle at the <paramref name='radians'/> measurement. 
		/// 0 radians is East of center, increases clockwise.
		/// </summary>
		public WPoint PointAtRadians(double radians)
		{
			radians = radians % RADIANS_360DEGREES;
			double deltaX = 0;
			double deltaY = 0;
			if(radians == 0)
			{
				deltaX = Radius;
			}
			else if(radians < RADIANS_90DEGREES)
			{
				deltaX = Math.Cos(radians) * Radius;
				deltaY = Math.Sin(radians) * Radius;
			}
			else if(radians == RADIANS_90DEGREES)
			{
				deltaY = Radius;
			}
			else if(radians < RADIANS_180DEGREES)
			{
				deltaX = -1 * Math.Cos(RADIANS_180DEGREES - radians) * Radius;
				deltaY = Math.Sin(RADIANS_180DEGREES - radians) * Radius;
			}
			else if(radians == RADIANS_180DEGREES)
			{
				deltaX = -1 * Radius;
			}
			else if(radians < RADIANS_270DEGREES)
			{
				deltaX = -1 * Math.Cos(radians - RADIANS_180DEGREES) * Radius;
				deltaY = -1 * Math.Sin(radians - RADIANS_180DEGREES) * Radius;
			}
			else if(radians == RADIANS_270DEGREES)
			{
				deltaY = -1 * Radius;
			}
			else //radians < Math.PI * 2
			{
				deltaX = Math.Cos(RADIANS_360DEGREES - radians) * Radius;
				deltaY = -1 * Math.Sin(RADIANS_360DEGREES - radians) * Radius;
			}

			switch(Geometry.CoordinatePlane)
			{
				case Geometry.CoordinatePlanes.Screen: return new WPoint(Center.X + deltaX, Center.Y + deltaY);
				case Geometry.CoordinatePlanes.Paper: return new WPoint(Center.X + deltaX, Center.Y - deltaY);
				default: throw new NotImplementedException("Coordinate plane not supported.");
			}
		}

		/// <summary>
		/// Returns the point on this circle at the <paramref name='degrees'/> measurement. 
		/// 0 degrees is East of center, increases clockwise.
		/// </summary>
		public WPoint PointAtDegrees(double degrees)
		{
			return PointAtRadians(DegreesToRadians(degrees));
		}

		/// <summary>
		/// Given a line from the center of this circle to a point (<paramref name='lineEnd'/>), what degrees is the line angle at? 
		/// 0 degrees is East of center, increases clockwise.
		/// </summary>
		public double DegreesAtPoint(WPoint lineEnd)
		{
			if(Geometry.CoordinatePlane == Geometry.CoordinatePlanes.None)
				throw new ArgumentException("Coordinate plane required.");

			Geometry.Direction direction = Geometry.LineDirection(Center, lineEnd);
			switch(direction)
			{
				case Geometry.Direction.East: return 0;
				case Geometry.Direction.South: return 90;
				case Geometry.Direction.West: return 180;
				case Geometry.Direction.North: return 270;
			}

			double lineLength = Center.Distance(lineEnd);
			double radians = Math.Abs(Math.Asin((lineEnd.Y - Center.Y) / lineLength));
			double degrees = Shapes.WCircle.RadiansToDegrees(radians) % DEGREES_IN_CIRCLE;
			switch(direction)
			{
				case Geometry.Direction.SouthEast: return degrees;
				case Geometry.Direction.SouthWest: return DEGREES_IN_HALF_CIRCLE - degrees;
				case Geometry.Direction.NorthWest: return DEGREES_IN_HALF_CIRCLE + degrees;
				case Geometry.Direction.NorthEast: return DEGREES_IN_CIRCLE - degrees;
			}

			throw new NotImplementedException(String.Format("Direction not supported: {0}.", direction));
		}

		/// <returns>Null (no intercepts), or array of length 1 or 2.</returns>
		public WPoint[] GetIntersectionPoints(WLine line)
		{
			//line does not intersect if perpendicular line from circle-center to line is longer than circle-radius
			WPoint perpendicularToCenter = line.GetPerpendicularIntersect(Center);
			if(perpendicularToCenter.Distance(Center) > Radius)
				return null;

			//equation of circle with radius r and center (h, k)
			//is (x - h)^2 + (y - k)^2 = r^2

			//line: y = mx + b
			//circle: (x - h)^2 + (y - k)^2 = r^2
			//substitute y: (x - h)^2 + (mx + b - k)^2 = r^2
			//expand: x^2 - 2hx + h^2 + m^2x^2 + 2(b - k)mx + (b - k)^2 - r^2 = 0
			//group: (1 + m^2)x^2 + (-2h + 2(b - k)m)x + (h^2 + (b - k)^2 - r^2) = 0
			//quadratic equation: if 0 = Ax^2 + Bx + C, then x = (-B +- sqrt(B^2 - 4AC)) / 2A
			double A = 1 + Math.Pow(line.Slope, 2);
			double B = (-2 * Center.X) + (2 * (line.YIntercept - Center.Y) * line.Slope);
			double C = Math.Pow(Center.X, 2) + Math.Pow(line.YIntercept - Center.Y, 2) - Math.Pow(Radius, 2);

			double x1 = (-1*B + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
			double x2 = (-1*B - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
			double y1 = line.Slope * x1 + line.YIntercept;
			double y2 = line.Slope * x2 + line.YIntercept;
			if(line.IsVertical)
			{
				x1 = line.A.X;
				x2 = line.A.X;
				//must use circle equation instead of line equation to find y's
				y1 = Center.Y + Math.Sqrt(Math.Pow(Radius, 2) - Math.Pow(x1 - Center.X, 2));
				y2 = Center.Y - Math.Sqrt(Math.Pow(Radius, 2) - Math.Pow(x1 - Center.X, 2));
			}
			if(line.IsHorizontal)
			{
				y1 = line.A.Y;
				y2 = line.A.Y;
			}
			WPoint point1 = new WPoint(x1, y1);
			WPoint point2 = new WPoint(x2, y2);
			List<WPoint> result = new List<WPoint>() { point1 };
			if(point1 != point2)
				result.Add(point2);
			return result.ToArray();
		}

		//todo: is it worth making a Degree and a Radian struct? for being precise in what data is expected/returned?

		/// <summary>Find the intersection points between the edge of this circle and the <paramref name='lineSegment'/>.</summary>
		/// <returns>Null (no intercepts), or array of length 1, or array of length 2.</returns>
		public WPoint[] GetIntersectionPoints(WLineSegment lineSegment)
		{
			WPoint[] lineIntersectionPoints = GetIntersectionPoints(lineSegment.ToWLine());
			if(lineIntersectionPoints == null)
				return null;
			List<WPoint> segmentIntersectionPoints = new List<WPoint>();
			foreach(WPoint point in lineIntersectionPoints)
			{
				if(lineSegment.Overlaps(point))
					segmentIntersectionPoints.Add(point);
			}
			if(segmentIntersectionPoints.Count == 0)
				return null;
			return segmentIntersectionPoints.ToArray();
		}

		/// <summary>
		/// Convert degrees to radians.
		/// </summary>
		public static double DegreesToRadians(double degrees)
		{
			return degrees * Math.PI / 180;
		}

		/// <summary>
		/// Convert radians to degrees.
		/// </summary>
		public static double RadiansToDegrees(double radians)
		{
			return radians * 180 / Math.PI;
		}

		/// <summary>
		/// Scale circle down by <paramref name='b'/> amount. Affects length and location measures.
		/// </summary>
		/// <example><c>circle / 2</c> returns a new Circle with half the radius and half the distance from point (0,0).</example>
		public static WCircle operator /(WCircle a, double b)
		{
			return new WCircle(a.Center / b, a.Radius / b);
		}

		/// <summary>Circle centers and radiuses are the same.</summary>
		public static bool operator ==(WCircle a, WCircle b)
		{
			return (a.Center == b.Center && a.Radius == b.Radius);
		}

		/// <summary>Circle centers or radiuses are different.</summary>
		public static bool operator !=(WCircle a, WCircle b)
		{
			return (a.Center != b.Center || a.Radius != b.Radius);
		}

		/// <duplicate cref='operator ==(WCircle,WCircle)'/>
		public override bool Equals(Object b)
		{
			if(b != null && b is WCircle)
			{
				return (this == (WCircle)b);
			}
			return false;
		}

		/// <summary></summary>
		public override int GetHashCode()
		{
			return Center.GetHashCode() ^ Radius.GetHashCode();
		}

		/// <summary>Format "C:(x,y) R:radius"</summary>
		public override string ToString()
		{
			return String.Format("C:({0},{1}) R:{2}", X, Y, Radius);
		}

		/// <inheritdoc/>
		public void Paint(Graphics graphics, Pen pen, double unitsToPixels)
		{
			graphics.DrawArc(pen, 
				(float)((X - Radius) * unitsToPixels), 
				(float)((Y - Radius) * unitsToPixels), 
				(float)(Diameter * unitsToPixels), 
				(float)(Diameter * unitsToPixels), 
				0, 
				DEGREES_IN_CIRCLE); 
		}
	}
}
