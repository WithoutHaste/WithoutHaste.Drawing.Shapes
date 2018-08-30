using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// A wedge is a slice of a circle. It is also known as a circular sector. Immutable.
	/// </summary>
	public class Wedge : WedgeUnbound, IDraw
	{
		/// <summary></summary>
		public readonly double Radius;

		/// <summary>Full circle that this Wedge is a part of.</summary>
		public Circle Circle { get { return new Circle(Center, Radius); } }
		/// <summary>Point on circumference of Circle where Wedge begins.</summary>
		public Dot StartPoint { get { return Circle.PointAtDegrees(Degrees.Start); } }
		/// <summary>Point on circumference of Circle where Wedge ends.</summary>
		public Dot EndPoint { get { return Circle.PointAtDegrees(Degrees.End); } }
		/// <summary>The point at the middle of the arc.</summary>
		public Dot ArcPoint { get { return Circle.PointAtDegrees(Degrees.Middle); } }
		/// <summary>
		///  <list type="bullet">
		///   <listheader>
		///    The boundary points of the Wedge:
		///   </listheader>
		///   <item>the center of the circle</item>
		///   <item>StartPoint</item>
		///   <item>EndPoint</item>
		///   <item>ArcPoint</item>
		///  </list>
		/// </summary>
		public Dot[] FourPoints { get { return new Dot[] { Circle.Center, StartPoint, EndPoint, ArcPoint }; } }
		/// <summary>
		///  <list type="bullet">
		///   <listheader>
		///    The straight edges of the Wedge:
		///   </listheader>
		///   <item>Center to StartPoint</item>
		///   <item>Center to EndPoint</item>
		///  </list>
		/// </summary>
		public LineSegment[] LineEdges { get { return new LineSegment[] { new LineSegment(Circle.Center, StartPoint), new LineSegment(Circle.Center, EndPoint) }; } }

		/// <summary>See <see cref="IDraw"/>.</summary>
		public double MaxX {
			get {
				double maxX = Math.Max(StartPoint.X, EndPoint.X);
				if(Degrees.Overlaps(Circle.MaxXDegrees))
					maxX = Math.Max(maxX, Circle.Center.X + Circle.Radius);
				else
					maxX = Math.Max(maxX, Circle.Center.X);
				return maxX;
			}
		}
		/// <summary>See <see cref="IDraw"/>.</summary>
		public double MaxY {
			get {
				double maxY = Math.Max(StartPoint.Y, EndPoint.Y);
				if(Degrees.Overlaps(Circle.MaxYDegrees))
					maxY = Math.Max(maxY, Circle.Center.Y + Circle.Radius);
				else
					maxY = Math.Max(maxY, Circle.Center.Y);
				return maxY;
			}
		}

		/// <summary></summary>
		public Wedge(Circle circle, RangeCircular radius) : base(circle.Center, radius)
		{
			Radius = circle.Radius;
		}

		/// <summary></summary>
		public Wedge(Circle circle, double rangeStart, double rangeEnd) : base(circle.Center, rangeStart, rangeEnd)
		{
			Radius = circle.Radius;
		}

		/// <summary>
		/// Any part of this wedge overlaps any part of circle B.
		/// </summary>
		public bool Overlaps(Circle b)
		{
			Wedge a = this;
			Dot[] intersections = a.Circle.GetIntersectionPoints(b);
			if(intersections == null)
			{
				if(!a.Circle.ContainsOrIsContained(b))
				{
					return false;
				}
			}

			//line edge overlaps circle
			foreach(LineSegment lineA in this.LineEdges)
			{
				if(b.Overlaps(lineA))
					return true;
			}
			//arc overlaps circle
			if(a.ArcOverlapsArc(new Wedge(b, 0, Circle.DEGREES_IN_CIRCLE)))
				return true;
			//wedge entirely contains circle or circle entirely contains wedge
			if(a.Contains(b))
				return true;
			if(b.Contains(a))
				return true;

			return false;
		}

		/// <summary>
		/// Any part of this wedge overlaps any part of wedge B.
		/// </summary>
		public bool Overlaps(Wedge b)
		{
			Wedge a = this;
			Dot[] intersections = a.Circle.GetIntersectionPoints(b.Circle);
			if(intersections == null)
			{
				if(!a.Circle.ContainsOrIsContained(b.Circle))
				{
					return false;
				}
			}

			//line edge overlaps line edge
			foreach(LineSegment lineA in this.LineEdges)
			{
				foreach(LineSegment lineB in b.LineEdges)
				{
					if(lineA.Overlaps(lineB))
						return true;
				}
			}
			//arc overlaps line edge
			foreach(LineSegment lineA in this.LineEdges)
			{
				if(b.ArcOverlaps(lineA))
					return true;
			}
			foreach(LineSegment lineB in b.LineEdges)
			{
				if(a.ArcOverlaps(lineB))
					return true;
			}
			//arc overlaps arc
			if(a.ArcOverlapsArc(b))
				return true;
			//one wedge entirely contains the other (all three points from one wedge inside the other)
			//	there are cases where all three points are inside, but arc protrudes outside - not important here since that still counts as overlapping
			if(Contains(b.Circle.Center))
			{
				if(Contains(b.StartPoint))
				{
					if(Contains(b.EndPoint))
						return true;
				}
			}

			return false;
		}

		/// <summary>
		/// The arc is the curved circle segment part of the wedge.
		/// </summary>
		public bool ArcOverlaps(LineSegment line)
		{
			//find intersection points between full circle and line segment
			Dot[] fullCircleIntersections = Circle.GetIntersectionPoints(line);
			if(fullCircleIntersections == null)
				return false;
			//find degrees from circle center to intersection points
			//are any of those degrees within the wedge degree range?
			foreach(Dot point in fullCircleIntersections)
			{
				double degrees = Circle.DegreesAtPoint(point);
				if(Degrees.Overlaps(degrees))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// The arc is the curved circle segment part of the wedge.
		/// </summary>
		public bool ArcOverlapsArc(Wedge b)
		{
			Wedge a = this;
			Dot[] fullCircleIntersections = a.Circle.GetIntersectionPoints(b.Circle);
			if(fullCircleIntersections == null)
				return false;
			foreach(Dot point in fullCircleIntersections)
			{
				if(a.Circle.Center == point || a.Degrees.Overlaps(a.Circle.DegreesAtPoint(point)))
				{
					if(b.Circle.Center == point || b.Degrees.Overlaps(b.Circle.DegreesAtPoint(point)))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Circle B lies entirely within this wedge.
		/// </summary>
		public bool Contains(Circle b)
		{
			Dot[] tangentPoints = b.GetTangentPoints(this.Circle.Center);
			foreach(Dot point in tangentPoints)
			{
				if(!Contains(point))
					return false;
			}
			return true;
		}

		/// <summary>
		/// This wedge contains point B, including point B being on an edge of the wedge.
		/// </summary>
		public bool Contains(Dot b)
		{
			double distance = Circle.Center.Distance(b);
			if(distance > Circle.Radius)
				return false;
			double degrees = Circle.DegreesAtPoint(b);
			return Degrees.Overlaps(degrees);
		}

		/// <summary>
		/// Scale wedge down by B amount. Affects length and location measures, but not degrees.
		/// </summary>
		public static Wedge operator /(Wedge a, double b)
		{
			return new Wedge(a.Circle / b, a.Degrees);
		}

		/// <summary>See <see cref="IDraw"/>.</summary>
		public void Paint(Graphics graphics, Pen pen, double unitsToPixels)
		{
			graphics.DrawArc(pen, 
				(float)((Circle.X - Circle.Radius) * unitsToPixels), 
				(float)((Circle.Y - Circle.Radius) * unitsToPixels), 
				(float)(Circle.Diameter * unitsToPixels), 
				(float)(Circle.Diameter * unitsToPixels), 
				(float)Degrees.Start, 
				(float)Degrees.Span);
			graphics.DrawLine(pen,
				(float)(Circle.Center.X * unitsToPixels),
				(float)(Circle.Center.Y * unitsToPixels),
				(float)(StartPoint.X * unitsToPixels),
				(float)(StartPoint.Y * unitsToPixels)
			);
			graphics.DrawLine(pen,
				(float)(Circle.Center.X * unitsToPixels),
				(float)(Circle.Center.Y * unitsToPixels),
				(float)(EndPoint.X * unitsToPixels),
				(float)(EndPoint.Y * unitsToPixels)
			);
		}

		/// <summary></summary>
		public override string ToString()
		{
			return String.Format("{0} Degrees:{1}", Circle, Degrees);
		}
	}
}
