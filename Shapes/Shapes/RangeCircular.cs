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
		/// <summary>The distance from Start when the range loops back to Start.</summary>
		/// <remarks>If your Start is 0, CircularModulus will be the same as End.</remarks>
		public readonly int CircularModulus;

		/// <summary>Length from Start to End. Always positive.</summary>
		public override double Span {
			get {
				if(Start == End)
					return CircularModulus;
				if(Start < End)
					return End - Start;
				return CircularModulus - Start + End;
			}
		}

		/// <summary>Middle value in range.</summary>
		public override double Middle {
			get {
				if(Start == End)
					return CircularModulus / 2;
				if(Start < End)
					return Start + ((End - Start) / 2);
				return Mod(Start + (Span / 2));
			}
		}

		/// <summary></summary>
		public RangeCircular(double s, double e, int mod) : base(Mod(s, mod), Mod(e, mod))
		{
			if(mod <= 0)
				throw new ArgumentException("RangeCircular.Modulus must be greater than 0.");
			CircularModulus = mod;
		}

		/// <summary>Create a range with this span, middle value, and modulus.</summary>
		public static RangeCircular Centered(double center, double span, int mod)
		{
			return new RangeCircular(center - (span / 2), center + (span / 2), mod);
		}

		/// <summary></summary>
		public bool Overlaps(RangeCircular b)
		{
			return (this.Overlaps(b.Start) || this.Overlaps(b.End) || b.Overlaps(this.Start) || b.Overlaps(this.End));
		}

		/// <summary></summary>
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
		/// <para>Returns a range that covers all the area both A and B cover, including any gap in between.</para>
		/// <para>If the ranges overlap, there is no gap filled in.</para>
		/// <para>Gaps are covered from direction A to B, therefore this operation is not commutative.</para>
		/// </summary>
		public static RangeCircular operator +(RangeCircular a, RangeCircular b)
		{
			if(a.CircularModulus != b.CircularModulus)
				throw new ArgumentException("RangeCirculars with different Modulus values cannot be combined.");
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
