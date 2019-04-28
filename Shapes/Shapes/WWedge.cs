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
	/// <remarks>
	/// "Arc" refers to the segment of circle's circumference that makes up the curved edge of the wedge. And arc is 1-dimensional; an arc is a curved line.
	/// </remarks>
	public class WWedge : WWedgeUnbound, IDraw//, IClosedFigure
	{
		/// <summary>The radius of the full circle this wedge is a slice of. Also the length of either straight side of the wegde.</summary>
		public readonly double Radius;

		/// <summary>The full circle that this wedge is a part of.</summary>
		public WCircle Circle { get { return new WCircle(Center, Radius); } }

		/// <summary>The point on circumference of Circle where the wedge begins.</summary>
		public WPoint StartPoint { get { return Circle.PointAtDegrees(Degrees.Start); } }

		/// <summary>The point on circumference of Circle where the wedge ends.</summary>
		public WPoint EndPoint { get { return Circle.PointAtDegrees(Degrees.End); } }

		/// <summary>The point at the middle of the arc edge of the wedge.</summary>
		public WPoint ArcPoint { get { return Circle.PointAtDegrees(Degrees.Middle); } }

		/// <summary>
		/// The boundary points of the wedge:
		///  <list type="bullet">
		///   <item>Center</item>
		///   <item>StartPoint</item>
		///   <item>EndPoint</item>
		///   <item>ArcPoint</item>
		///  </list>
		/// </summary>
		public WPoint[] FourPoints { get { return new WPoint[] { Circle.Center, StartPoint, EndPoint, ArcPoint }; } }

		/// <summary>
		/// The straight edges of the wedge:
		///  <list type="bullet">
		///   <item>Center to StartPoint</item>
		///   <item>Center to EndPoint</item>
		///  </list>
		/// </summary>
		public WLineSegment[] LineEdges { get { return new WLineSegment[] { new WLineSegment(Circle.Center, StartPoint), new WLineSegment(Circle.Center, EndPoint) }; } }

		/// <inheritdoc/>
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

		/// <inheritdoc/>
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

		/// <param name="circle">The full circle this wedge is a part of.</param>
		/// <param name="degreeRange">The range of degrees this wedge covers.</param>
		public WWedge(WCircle circle, WRangeCircular degreeRange) : base(circle.Center, degreeRange)
		{
			Radius = circle.Radius;
		}

		/// <param name="circle">The full circle this wedge is a part of.</param>
		/// <param name="degreeStart">The starting degree the wedge covers.</param>
		/// <param name="degreeEnd">The ending degree the wedge covers.</param>
		public WWedge(WCircle circle, double degreeStart, double degreeEnd) : base(circle.Center, degreeStart, degreeEnd)
		{
			Radius = circle.Radius;
		}

		/// <summary>
		/// Returns true if any part of this wedge overlaps any part of circle <paramref name='b'/>.
		/// </summary>
		public bool Overlaps(WCircle b)
		{
			WWedge a = this;
			WPoint[] intersections = a.Circle.GetIntersectionPoints(b);
			if(intersections == null)
			{
				if(!a.Circle.ContainsOrIsContained(b))
				{
					return false;
				}
			}

			//line edge overlaps circle
			foreach(WLineSegment lineA in this.LineEdges)
			{
				if(b.Overlaps(lineA))
					return true;
			}
			//arc overlaps circle
			if(a.ArcOverlapsArc(new WWedge(b, 0, WCircle.DEGREES_IN_CIRCLE)))
				return true;
			//wedge entirely contains circle or circle entirely contains wedge
			if(a.Contains(b))
				return true;
			if(b.Contains(a))
				return true;

			return false;
		}

		/// <summary>
		/// Returns true if any part of this wedge overlaps any part of wedge <paramref name='b'/>.
		/// </summary>
		public bool Overlaps(WWedge b)
		{
			WWedge a = this;
			WPoint[] intersections = a.Circle.GetIntersectionPoints(b.Circle);
			if(intersections == null)
			{
				if(!a.Circle.ContainsOrIsContained(b.Circle))
				{
					return false;
				}
			}

			//line edge overlaps line edge
			foreach(WLineSegment lineA in this.LineEdges)
			{
				foreach(WLineSegment lineB in b.LineEdges)
				{
					if(lineA.Overlaps(lineB))
						return true;
				}
			}
			//arc overlaps line edge
			foreach(WLineSegment lineA in this.LineEdges)
			{
				if(b.ArcOverlaps(lineA))
					return true;
			}
			foreach(WLineSegment lineB in b.LineEdges)
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
		/// Returns true if the arc overlaps any part of the <paramref name='lineSegment'/>.
		/// </summary>
		public bool ArcOverlaps(WLineSegment lineSegment)
		{
			//find intersection points between full circle and line segment
			WPoint[] fullCircleIntersections = Circle.GetIntersectionPoints(lineSegment);
			if(fullCircleIntersections == null)
				return false;
			//find degrees from circle center to intersection points
			//are any of those degrees within the wedge degree range?
			foreach(WPoint point in fullCircleIntersections)
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
		/// Returns true if this arc overlaps any part of <paramref name='b'/>'s arc.
		/// </summary>
		public bool ArcOverlapsArc(WWedge b)
		{
			WWedge a = this;
			WPoint[] fullCircleIntersections = a.Circle.GetIntersectionPoints(b.Circle);
			if(fullCircleIntersections == null)
				return false;
			foreach(WPoint point in fullCircleIntersections)
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
		/// Returns true if this wedge fully contains circle <paramref name='b'/>.
		/// </summary>
		public bool Contains(WCircle b)
		{
			WPoint[] tangentPoints = b.GetTangentPoints(this.Circle.Center);
			foreach(WPoint point in tangentPoints)
			{
				if(!Contains(point))
					return false;
			}
			return true;
		}

		/// <summary>
		/// Returns true if this wedge contains point <paramref name='b'/>, including if <paramref name='b'/> lies on one of this wedge's edges.
		/// </summary>
		public bool Contains(WPoint b)
		{
			double distance = Circle.Center.Distance(b);
			if(distance > Circle.Radius)
				return false;
			double degrees = Circle.DegreesAtPoint(b);
			return Degrees.Overlaps(degrees);
		}

		/// <summary>
		/// Scale wedge down by <paramref name='b'/> amount. Affects length and location measures, but not degrees.
		/// </summary>
		public static WWedge operator /(WWedge a, double b)
		{
			return new WWedge(a.Circle / b, a.Degrees);
		}

		/// <inheritdoc/>
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

		/// <summary>Format "C:(X,Y) R:Radius Degrees:Start-End".</summary>
		public override string ToString()
		{
			return String.Format("{0} Degrees:{1}", Circle, Degrees);
		}
	}
}
