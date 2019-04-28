using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Represents a rectangle or square.
	/// </summary>
	public class WRectangle : WShape, IDraw//, IClosedFigure
	{
		/// <summary>Refers to the top-left corner, regardless of the coordinate plane being used.</summary>
		public readonly WPoint Corner;
		/// <summary>Length of horizontal edges, when rectangle is at 0 degree rotation.</summary>
		public readonly double Width;
		/// <summary>Length of vertical edges, when rectangle is at 0 degree rotation.</summary>
		public readonly double Height;
		/// <summary>Degrees of rotation.</summary>
		/// <remarks>A positive rotation means the top-edge of the rectangle (the "width" edge connecting to the <see cref='Corner'/>) has rotated counter-clockwise around the <see cref='Corner'/>.</remarks>
		public readonly double Rotation;

		#region Properties

		/// <summary>Minimum x coordinate required to draw the figure.</summary>
		public double MinX { get { return Corners.Min(c => c.X); } }
		/// <summary>Minimum y coordinate required to draw the figure.</summary>
		public double MinY { get { return Corners.Min(c => c.Y); } }
		/// <inheritdoc/>
		public double MaxX { get { return Corners.Max(c => c.X); } }
		/// <inheritdoc/>
		public double MaxY { get { return Corners.Max(c => c.Y); } }

		private WPoint[] corners;
		/// <summary>Returns all four corners, starting with the top-left (or reference corner) and proceeding in clockwise order.</summary>
		public WPoint[] Corners {
			get {
				if(corners == null)
				{
					corners = new WPoint[4];
					corners[0] = Corner;
					if(Geometry.IsCoordinatePlanePaper)
					{
						corners[1] = Corner + new WPoint(Width, 0);
						corners[2] = Corner + new WPoint(Width, -1 * Height);
						corners[3] = Corner + new WPoint(0, -1 * Height);
					}
					else if(Geometry.IsCoordinatePlaneScreen)
					{
						corners[1] = Corner + new WPoint(Width, 0);
						corners[2] = Corner + new WPoint(Width, Height);
						corners[3] = Corner + new WPoint(0, Height);
					}
					else
					{
						throw new NotImplementedException("Unknown Coordinate Plane: " + Geometry.CoordinatePlane);
					}
					corners[1] = corners[1].Rotate(Corner, Rotation);
					corners[2] = corners[2].Rotate(Corner, Rotation);
					corners[3] = corners[3].Rotate(Corner, Rotation);
				}
				return corners;
			}
		}

		private WLineSegment[] edges;
		/// <summary>Returns all four edges, starting with the top-left (or reference corner) and proceeding in clockwise order.</summary>
		public WLineSegment[] Edges {
			get {
				if(edges == null)
				{
					edges = new WLineSegment[4];
					edges[0] = new WLineSegment(Corners[0], Corners[1]);
					edges[1] = new WLineSegment(Corners[1], Corners[2]);
					edges[2] = new WLineSegment(Corners[2], Corners[3]);
					edges[3] = new WLineSegment(Corners[3], Corners[0]);
				}
				return edges;
			}
		}

		/// <summary>Returns the distance between diagonal corners. Absolute value.</summary>
		public double DiagonalLength {
			get {
				return Corners[0].Distance(Corners[2]);
			}
		}

		/// <summary>True if the rectangle is a square.</summary>
		public bool IsSquare {
			get {
				return (Width == Height);
			}
		}

		/// <summary>True if the rectangle is at 0 degrees rotation.</summary>
		public bool IsFlat {
			get {
				return (Rotation == 0);
			}
		}

		#endregion

		#region Constructors

		/// <summary>Corner defaults to (0, 0). Rotation defaults to 0 degrees.</summary>
		public WRectangle(double width, double height) : this(width, height, new WPoint(0, 0)) { }

		/// <summary>Rotation defaults to 0 degrees.</summary>
		public WRectangle(double width, double height, WPoint corner) : this(width, height, corner, 0) { }

		/// <summary></summary>
		public WRectangle(double width, double height, WPoint corner, double rotation)
		{
			Width = width;
			Height = height;
			Corner = corner;
			Rotation = rotation;
		}

		#endregion

		/// <summary>Returns the smallest "IsFlat" rectangle that encloses this rectangle.</summary>
		public WRectangle GetFlatEnclosingRectangle()
		{
			if(IsFlat)
				return this;
			double minX = Corners.Min(c => c.X);
			double minY = Corners.Min(c => c.Y);
			double maxX = Corners.Max(c => c.X);
			double maxY = Corners.Max(c => c.Y);
			if(Geometry.IsCoordinatePlanePaper)
			{
				return new WRectangle(width: maxX - minX, height: maxY - minY, corner: new WPoint(minX, maxY), rotation: 0);
			}
			else if(Geometry.IsCoordinatePlaneScreen)
			{
				return new WRectangle(width: maxX - minX, height: maxY - minY, corner: new WPoint(minX, minY), rotation: 0);
			}
			throw new NotImplementedException("Unknown Coordinate Plane: " + Geometry.CoordinatePlane);
		}

		/// <summary></summary>
		public Intersection GetIntersection(WLine line)
		{
			//if line intersects 1 corner, that's one point
			//if line intersects 2 corners, that's a line segment
			List<WPoint> overlapsCorners = new List<WPoint>();
			foreach(WPoint corner in Corners)
			{
				if(corner.Overlaps(line))
					overlapsCorners.Add(corner);
			}
			if(overlapsCorners.Count == 1)
				return new Intersection(overlapsCorners[0]);
			if(overlapsCorners.Count == 2)
				return new Intersection(overlapsCorners.ToArray());

			//either line intersects two edges, or none at all
			List<WPoint> intersections = new List<WPoint>();
			foreach(WLineSegment edge in Edges)
			{
				Intersection intersection = edge.GetIntersection(line);
				if(intersection == Intersection.NONE) continue;
				intersections.Add(intersection.Point);
			}
			if(intersections.Count == 2)
				return new Intersection(intersections.ToArray());

			return Intersection.NONE;
		}

		///// <inheritdoc/>
		//public GraphicsPath Slice(WLine a, WLine b)
		//{
		//	Intersection intersectionA = GetIntersection(a);
		//	Intersection intersectionB = GetIntersection(b);
		//	if(intersectionA == Intersection.NONE && intersectionB == Intersection.NONE)
		//		return null; //TODO what if lines were on either side and actually enveloped the entire rect?
		//	//one line off rect, one on it
		//	//one line on a corner, one on it fully
		//	//both lines on it fully
		//		//but do they slice a corner or just a trapezoid?
		//}

		/// <inheritdoc/>
		public void Paint(Graphics graphics, Pen pen, double unitsToPixels)
		{
			graphics.DrawLines(pen, new Point[] {
				(Corners[0] * unitsToPixels).ToPoint(),
				(Corners[1] * unitsToPixels).ToPoint(),
				(Corners[2] * unitsToPixels).ToPoint(),
				(Corners[3] * unitsToPixels).ToPoint(),
				(Corners[0] * unitsToPixels).ToPoint()
			});
		}
	}
}
