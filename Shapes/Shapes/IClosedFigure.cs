using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>Represents a closed figure shape.</summary>
	public interface IClosedFigure
	{
		/// <summary>
		/// Cuts a slice out of a shape, bounded by two lines running completely through the figure.
		/// Assumes lines <paramref name='a'/> and <paramref name='b'/> are parallel and different.
		/// </summary>
		/// <param name="a">One bounding line.</param>
		/// <param name="b">Other bounding line.</param>
		/// <returns>Returns a path from one bounding line, around the figure, to the other bounding line, and back around the figure.</returns>
		GraphicsPath Slice(WLine a, WLine b);
	}
}
