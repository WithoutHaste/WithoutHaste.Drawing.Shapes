using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Global settings and miscellaneous operations.
	/// </summary>
    public static class Geometry
    {
		//todo: make sure MarginOfError is applied to all equality in shapes operations, like Circle.ContainsPoint
		//todo: is there reason to allow different margins of error for different shapes? like, they could override the global geometry margin of error if they are set

		/// <summary>
		/// When determining equality, all values have a +/- margin of error. This setting is used in all Shape operations that check equality.
		/// </summary>
		public static double MarginOfError = 0.00000001;

		/// <summary>
		/// This coordinate plane is used in all Shape operations that require one.
		/// </summary>
		public static CoordinatePlanes CoordinatePlane = CoordinatePlanes.Screen;

		//todo: why is enum CoordinatePlanes plural and Direction singular?

		/// <summary>
		/// Determines how cardinal directions apply to coordinates.
		/// </summary>
		public enum CoordinatePlanes : int {
			/// <summary></summary>
			None = 0,
			/// <summary>
			/// Computer screens have (0,0) in the upper-left corner and increase to the right and down.
			/// </summary>
			Screen,
			/// <summary>
			/// Paper graphs have (0,0) in the lower-left corner and increase to the right and up.
			/// </summary>
			Paper
		};

		/// <summary>
		/// Cardinal directions.
		/// </summary>
		public enum Direction : int {
			/// <summary></summary>
			None = 0,
			/// <summary></summary>
			East,
			/// <summary></summary>
			SouthEast,
			/// <summary></summary>
			South,
			/// <summary></summary>
			SouthWest,
			/// <summary></summary>
			West,
			/// <summary></summary>
			NorthWest,
			/// <summary></summary>
			North,
			/// <summary></summary>
			NorthEast
		};

		/// <summary>Check if values are equal, within the MarginOfError.</summary>
		public static bool WithinMarginOfError(double a, double b)
		{
			return (a >= b - MarginOfError && a <= b + MarginOfError);
		}

		//todo: better names for PointOnLine and PointPastLine, they are misleading

		/// <summary>
		/// Calculates point along line AB, starting at A and moving towards B
		/// </summary>
		/// <exception cref='ArgumentException'>Point A and B cannot be the same.</exception>
		public static WPoint PointOnLine(WPoint a, WPoint b, double distance)
		{
			double lineLength = a.Distance(b);
			if(lineLength == 0)
				throw new ArgumentException("Point A and B cannot be the same.");
			double lengthRatio = distance / lineLength;
			double x = ((1 - lengthRatio) * a.X) + (lengthRatio * b.X);
			double y = ((1 - lengthRatio) * a.Y) + (lengthRatio * b.Y);
			return new WPoint(x, y);
		}

		/// <summary>
		/// Calculates point along line AB, starting at B and moving away from A
		/// </summary>
		public static WPoint PointPastLine(WPoint a, WPoint b, double distance)
		{
			double lineLength = a.Distance(b);
			return PointOnLine(a, b, lineLength + distance);
		}

		//todo: couldn't LineDirection be moved to Line object? probably PointOnLine and PointPastLine could to.

		/// <summary>
		/// Given directed line A to B, what direction is it pointing?
		/// </summary>
		/// <remarks>
		/// North, South, East, and West answers are exact. So "North" means exactly North.
		/// The inbetween directions cover all remaining values. So "NorthWest" covers all values between North and West.
		/// </remarks>
		/// <exception cref='NotImplementedException'>Coordinate plane not supported.</exception>
		public static Direction LineDirection(WPoint a, WPoint b)
		{
			if(a == b) 
				return Direction.None;
			switch(CoordinatePlane)
			{
				case CoordinatePlanes.Screen: return LineDirection_Screen(a, b);
				case CoordinatePlanes.Paper: return LineDirection_Paper(a, b);
				default: throw new NotImplementedException("Coordinate plane not supported.");
			}
		}

		private static Direction LineDirection_Screen(WPoint a, WPoint b)
		{
			if(a.X == b.X)
			{
				return (a.Y < b.Y) ? Direction.South : Direction.North;
			}
			if(a.Y == b.Y)
			{
				return (a.X < b.X) ? Direction.East : Direction.West;
			}
			if(a.X < b.X)
			{
				return (a.Y < b.Y) ? Direction.SouthEast : Direction.NorthEast;
			}
			else
			{
				return (a.Y < b.Y) ? Direction.SouthWest : Direction.NorthWest;
			}
		}

		private static Direction LineDirection_Paper(WPoint a, WPoint b)
		{
			if(a.X == b.X)
			{
				return (a.Y < b.Y) ? Direction.North : Direction.South;
			}
			if(a.Y == b.Y)
			{
				return (a.X < b.X) ? Direction.East : Direction.West;
			}
			if(a.X < b.X)
			{
				return (a.Y < b.Y) ? Direction.NorthEast : Direction.SouthEast;
			}
			else
			{
				return (a.Y < b.Y) ? Direction.NorthWest : Direction.SouthWest;
			}
		}

	}
}
