﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// A wedge is a slice of a circle. An unbounded wedge is a slice of circle that extends outward from the center with no limit. Immutable.
	/// </summary>
	public class WWedgeUnbound : WShape
	{
		/// <summary>Center of the circle that defines this wedge.</summary>
		public readonly WPoint Center;

		/// <summary>The degrees of the defining circle that this wedge extends through.</summary>
		public readonly WRangeCircular Degrees;

		/// <summary>The total degrees this wedge covers.</summary>
		public double Span { get { return Degrees.Span; } }

		/// <summary>Starting degree.</summary>
		public double Start { get { return Degrees.Start; } }
		
		/// <summary>Ending degree.</summary>
		public double End { get { return Degrees.End; } }

		/// <summary></summary>
		public WWedgeUnbound(WPoint center, WRangeCircular degreeRange)
		{
			Center = center;
			Degrees = degreeRange;
		}

		/// <summary></summary>
		public WWedgeUnbound(WPoint center, double degreesRangeStart, double degreesRangeEnd)
		{
			Center = center;
			Degrees = new WRangeCircular(degreesRangeStart, degreesRangeEnd, WCircle.DEGREES_IN_CIRCLE);
		}
	}
}
