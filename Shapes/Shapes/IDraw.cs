using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Represents anything that can be drawn on a Graphics object.
	/// </summary>
	public interface IDraw
	{
		/// <summary>Maximum x coordinate required to draw the figure.</summary>
		double MaxX { get; }
		/// <summary>Maximum y coordinate required to draw the figure.</summary>
		double MaxY { get; }

		/// <summary>
		/// Draw the figure on the <paramref name='graphics'/> with the <paramref name='pen'/>.
		/// </summary>
		/// <param name="unitsToPixels">
		/// Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.
		/// </param>
		void Paint(Graphics graphics, Pen pen, double unitsToPixels);
	}
}
