using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Anything that can be drawn on a Graphics object.
	/// </summary>
	public interface IDraw
	{
		/// <summary>Maximum x coordinate required to draw the figure.</summary>
		double MaxX { get; }
		/// <summary>Maximum y coordinate required to draw the figure.</summary>
		double MaxY { get; }

		/// <summary>
		/// Draw the figure on the Graphics with the Pen.
		/// </summary>
		/// <param name="unitsToPixels">Conversion ratio from figure units to pixels.</param>
		void Paint(Graphics graphics, Pen pen, double unitsToPixels);
	}
}
