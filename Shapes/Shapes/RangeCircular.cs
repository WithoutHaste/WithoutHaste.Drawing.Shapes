using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// A range on a circular scale. Immutable.
	/// </summary>
	/// <remarks>
	/// A circular scale can be written shorthand as [0, CircularModulus), meaning 0 is included in the scale and CircularModulus is excluded from the scale.
	/// 
	/// The range may cover the entire scale, or only a portion of the scale.
	/// To cover the entire scale, set Start and End to the same value.
	/// 
	/// Throughout the documentation, "scale" refers to the full circular scale [0, CircularModulus) while "range" refers to a subset of values [Start, End].
	/// </remarks>
	/// <example>
	/// The degrees of a circle make up a circular scale [0, 360).
	/// The range may only cover [25, 45] of the scale [0, 360).
	/// In this case, Start=25, End=45, and CircularModulus=360.
	/// </example>
	/// <example>
	/// The hours of a clock make up a circular range [1, 13) for a normal clock, or [0, 24) for a military clock.
	/// Since RangeCircular always starts at 0, the normal clock would need to be represented as [0, 12). You'd need to handle the +1 offset when setting or displaying values.
	/// </example>
	public class RangeCircular : Range
	{
		/// <summary>The value at which the range loops back to 0.</summary>
		/// <remarks>In the context of this range, 0 and CircularModulus are the same value.</remarks>
		public readonly int CircularModulus;

		/// <summary>Distance from Start to End.</summary>
		public override double Span {
			get {
				if(Start == End)
					return CircularModulus;
				if(Start < End)
					return End - Start;
				return CircularModulus - Start + End;
			}
		}

		/// <summary>Middle value between Start and End.</summary>
		public override double Middle {
			get {
				if(Start == End)
					return CircularModulus / 2;
				if(Start < End)
					return Start + ((End - Start) / 2);
				return Mod(Start + (Span / 2));
			}
		}

		/// <exception cref='ArgumentException'>CircularModulus must be greater than 0.</exception>
		public RangeCircular(double start, double end, int circularModulus) : base(Mod(start, circularModulus), Mod(end, circularModulus))
		{
			if(circularModulus <= 0)
				throw new ArgumentException("CircularModulus must be greater than 0.");
			CircularModulus = circularModulus;
		}

		/// <exception cref='ArgumentException'>CircularModulus must be greater than 0.</exception>
		public static RangeCircular Centered(double middle, double span, int circularModulus)
		{
			return new RangeCircular(middle - (span / 2), middle + (span / 2), circularModulus);
		}

		/// <summary>Returns true if this range overlaps range <paramref name='b'/>.</summary>
		public bool Overlaps(RangeCircular b)
		{
			return (this.Overlaps(b.Start) || this.Overlaps(b.End) || b.Overlaps(this.Start) || b.Overlaps(this.End));
		}

		/// <summary>Returns true if this range includes value <paramref name='b'/>.</summary>
		/// <remarks>
		/// <paramref name='b'/> is first put in context of this scale [0, CircularModulus).
		///   <example>
		///   Value 13 on scale [0, 24) is converted to value 1 when compared to scale [0, 12) because <c>13 modulus 12 = 1</c>.
		///   
		///   Value 13 therefore does overlap range [0, 3] on scale [0, 12), but does not overlap range [2, 3] on scale [0, 12).
		///   </example>
		/// </remarks>
		public override bool Overlaps(double b)
		{
			b = Mod(b);
			if(Start == End)
			{
				return true;
			}
			if(Start <= End)
			{
				return (Start <= b && End >= b);
			}
			return ((Start <= b && b <= CircularModulus) || (0 <= b && End >= b));
		}

		/// <summary>
		/// Returns a range that covers all the area both <paramref name='a'/> and <paramref name='b'/> cover, including any gap in between.
		/// If the ranges overlap, there is no gap filled in.
		/// </summary>
		/// <remarks>
		/// Gaps are covered from direction <paramref name='a'/> to <paramref name='b'/>, therefore this operation is not commutative.
		///   <example>
		///   Consider range A is [0, 45] on scale [0, 360), and range B is range [90, 180] on scale [0, 360).
		///   A + B = range [0, 180] on scale [0, 360) which has a Span of 180.
		///   B + A = range [90, 45] on scale [0, 360) which has a Span of 315.
		///   </example>
		/// </remarks>
		/// <exception cref='ArgumentException'>RangeCirculars with different CircularModulus values cannot be combined.</exception>
		public static RangeCircular operator +(RangeCircular a, RangeCircular b)
		{
			if(a.CircularModulus != b.CircularModulus)
				throw new ArgumentException("RangeCirculars with different CircularModulus values cannot be combined.");
			if(a.Overlaps(b))
				return new RangeCircular(Math.Min(a.Start, b.Start), Math.Max(a.End, b.End), a.CircularModulus);
			return new RangeCircular(a.Start, b.End, a.CircularModulus);
		}

		/// <summary>Convert a number into this range.</summary>
		public double Mod(double number)
		{
			return Mod(number, CircularModulus);
		}

		/// <summary>
		/// Returns number modulus m. Ensures a positive result.
		/// </summary>
		public static double Mod(double number, int m)
		{
			if(m <= 0)
				throw new ArgumentException("RangeCircular.Mod requires a positive, non-zero M.");
			while(number < 0)
				number += m;
			return number % m;
		}

		/// <summary></summary>
		public static bool operator ==(RangeCircular a, RangeCircular b)
		{
			return (Geometry.WithinMarginOfError(a.Start, b.Start) && Geometry.WithinMarginOfError(a.End, b.End));
		}

		/// <summary></summary>
		public static bool operator !=(RangeCircular a, RangeCircular b)
		{
			return (!Geometry.WithinMarginOfError(a.Start, b.Start) || !Geometry.WithinMarginOfError(a.End, b.End));
		}

		/// <summary></summary>
		public override bool Equals(Object b)
		{
			if(b != null && b is RangeCircular)
			{
				return (this == (RangeCircular)b);
			}
			return false;
		}

		/// <summary></summary>
		public override int GetHashCode()
		{
			return Start.GetHashCode() ^ End.GetHashCode() ^ CircularModulus.GetHashCode();
		}
	}
}
