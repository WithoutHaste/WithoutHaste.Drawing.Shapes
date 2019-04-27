using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	//todo: why is Range a Shape?

	/// <summary>
	/// A linear range of values. Immutable.
	/// </summary>
	/// <remarks>
	/// Ranges are inclusive: both the Start and the End values are included in the range.
	/// </remarks>
	public class WRange : WShape
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
		public WRange(double start, double end)
		{
			Start = start;
			End = end;
		}

		/// <summary>Create a range with this span and middle value.</summary>
		public static WRange Centered(double middle, double span)
		{
			return new WRange(middle - (span / 2), middle + (span / 2));
		}

		/// <summary>Returns true if this range overlaps range <paramref name='b'/>.</summary>
		public virtual bool Overlaps(WRange b)
		{
			return (this.Overlaps(b.Start) || this.Overlaps(b.End) || b.Overlaps(this.Start) || b.Overlaps(this.End));
		}

		/// <summary>Returns true if this range includes value <paramref name='b'/>.</summary>
		public virtual bool Overlaps(double b)
		{
			return (Start <= b && End >= b);
		}

		/// <summary>
		/// Convert the <paramref name='value'/> in <paramref name='originalRange'/> to one in <paramref name='newRange'/>.
		/// </summary>
		/// <remarks>
		/// Essentially, <paramref name='originalRange'/> is scaled up or down to match <paramref name='newRange'/>.
		/// So the returned value is the same percentage along <paramref name='newRange'/> as the provided <paramref name='value'/> was along <paramref name='originalRange'/>.
		/// </remarks>
		public static double ConvertValue(WRange originalRange, WRange newRange, double value)
		{
			if(originalRange.Start != newRange.Start)
				throw new NotImplementedException("Not implemented: Range.ConvertValue when ranges have different minimum values.");

			double scale = newRange.Span / originalRange.Span;
			return ((value - originalRange.Start) * scale) + newRange.Start;
		}

		/// <summary>Format "Start-End".</summary>
		public override string ToString()
		{
			return String.Format("{0}-{1}", Start, End);
		}

		/// <summary>
		/// Returns a range that covers all the area both <paramref name='a'/> and <paramref name='b'/> cover, including any gap in between.
		/// This operation is commutative.
		/// </summary>
		public static WRange operator +(WRange a, WRange b)
		{
			return new WRange(Math.Min(a.Start, b.Start), Math.Max(a.End, b.End));
		}

		/// <summary></summary>
		public static bool operator ==(WRange a, WRange b)
		{
			return (Geometry.WithinMarginOfError(a.Start, b.Start) && Geometry.WithinMarginOfError(a.End, b.End));
		}

		/// <summary></summary>
		public static bool operator !=(WRange a, WRange b)
		{
			return (!Geometry.WithinMarginOfError(a.Start, b.Start) || !Geometry.WithinMarginOfError(a.End, b.End));
		}

		/// <summary></summary>
		public override bool Equals(Object b)
		{
			if(b != null && b is WRange)
			{
				return (this == (WRange)b);
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
