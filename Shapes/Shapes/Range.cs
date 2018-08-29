using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// A linear range of values. Immutable.
	/// </summary>
	public class Range : Shape
	{
		/// <summary>
		/// For non-circular ranges, operations assume that Start is the minimum value.
		/// </summary>
		public readonly double Start;
		/// <summary></summary>
		public readonly double End;

		/// <summary>End minus Start.</summary>
		public virtual double Span { get { return End - Start; } }
		/// <summary>Middle value between Start and End.</summary>
		public virtual double Middle { get { return Start + (Span / 2); } }

		/// <summary></summary>
		public Range(double start, double end)
		{
			Start = start;
			End = end;
		}

		/// <summary>Create a range with this span and middle value.</summary>
		public static Range Centered(double middle, double span)
		{
			return new Range(middle - (span / 2), middle + (span / 2));
		}

		/// <summary></summary>
		public virtual bool Overlaps(Range b)
		{
			return (this.Overlaps(b.Start) || this.Overlaps(b.End) || b.Overlaps(this.Start) || b.Overlaps(this.End));
		}

		/// <summary></summary>
		public virtual bool Overlaps(double b)
		{
			return (Start <= b && End >= b);
		}

		/// <summary>
		/// Convert a value in originalRange to one in newRange, assuming that the original range is re-scaled to the new range.
		/// </summary>
		public static double ConvertValue(Range originalRange, Range newRange, double value)
		{
			if(originalRange.Start != newRange.Start)
				throw new NotImplementedException("Not implemented: Range.ConvertValue when ranges have different minimum values.");

			double scale = newRange.Span / originalRange.Span;
			return ((value - originalRange.Start) * scale) + newRange.Start;
		}

		/// <summary>Format "start-end"</summary>
		public override string ToString()
		{
			return String.Format("{0}-{1}", Start, End);
		}

		/// <summary>
		/// <para>Returns a range that covers all the area both A and B cover, including any gap in between.</para>
		/// <para>This operation is commutative.</para>.
		/// </summary>
		public static Range operator +(Range a, Range b)
		{
			return new Range(Math.Min(a.Start, b.Start), Math.Max(a.End, b.End));
		}

		/// <summary></summary>
		public static bool operator ==(Range a, Range b)
		{
			return (Geometry.WithinMarginOfError(a.Start, b.Start) && Geometry.WithinMarginOfError(a.End, b.End));
		}

		/// <summary></summary>
		public static bool operator !=(Range a, Range b)
		{
			return (!Geometry.WithinMarginOfError(a.Start, b.Start) || !Geometry.WithinMarginOfError(a.End, b.End));
		}

		/// <summary></summary>
		public override bool Equals(Object b)
		{
			if(b != null && b is Range)
			{
				return (this == (Range)b);
			}
			return false;
		}

		/// <summary></summary>
		public override int GetHashCode()
		{
			return Start.GetHashCode() ^ End.GetHashCode();
		}
	}
}
