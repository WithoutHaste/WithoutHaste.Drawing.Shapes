using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Represents a rectangle or square.
	/// </summary>
	public class WRectangle : WShape
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

		/// <summary>Returns the distance between diagonal corners. Absolute value.</summary>
		public double Diagonal {
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
	}
}
