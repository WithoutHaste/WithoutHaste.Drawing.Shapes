using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Represents any planar (2D) figure with a single outline. Outline/edges may include straight sections and curved sections.
	/// </summary>
	public abstract class WClosedFigure : WShape, IDraw
	{
		/// <inheritdoc/>
		public abstract double MaxX { get; }
		/// <inheritdoc/>
		public abstract double MaxY { get; }

		/// <summary>
		/// Path of outline/edges of entire figure. Path is expected to be closed.
		/// </summary>
		abstract public GraphicsPath Path { get; }

		///// <summary>
		///// Takes a slice out of the figure and returns it.
		///// </summary>
		///// <param name="lineA">First boundary of slice.</param>
		///// <param name="lineB">Second boundary of slice. Expected to be parallel to <paramref name='lineA'/> and different from it.</param>
		///// <returns>Path of slice of figure.</returns>
		//public GraphicsPath Slice(WLine lineA, WLine lineB)
		//{
		//	//TODO: currently assumes all paths are made of straight lines
		//	//not sure I can get curved line data back out of GraphicsPath - if I can't, I'll need to roll my own version "WPath"

		//	//start at beginning of path
		//	//if already within slice, save this data
		//	//else if already intersecting a or b, save this data
		//	//else see if next edge intersects a or b

		//	GraphicsPath result = new GraphicsPath();
		//	for(int i = 0; i < Path.PathData.Points.Length; i++)
		//	{
		//		//if point is between lines or on a line, keep it

		//	}

		//}

		/// <inheritdoc/>
		public void Paint(Graphics graphics, Pen pen, double unitsToPixels)
		{
			Matrix scaleMatrix = new Matrix();
			scaleMatrix.Scale((float)unitsToPixels, (float)unitsToPixels);
			GraphicsPath scaledPath = (GraphicsPath)Path.Clone();
			scaledPath.Transform(scaleMatrix);
			graphics.DrawPath(pen, scaledPath);
		}

	}
}
