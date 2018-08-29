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
		double MaxX { get; }
		double MaxY { get; }

		void Paint(Graphics graphics, Pen pen, double unitsToPixels);
	}
}
