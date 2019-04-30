using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Line segment from point A to point B. Immutable.
	/// </summary>
	public class WLineSegment : WLine, IDraw
	{
		/// <inheritdoc/>
		public double MaxX { get { return Math.Max(A.X, B.X); } }
		/// <inheritdoc/>
		public double MaxY { get { return Math.Max(A.Y, B.Y); } }

		/// <summary>Distance between points A and B. Always positive.</summary>
		public double Length { get { return A.Distance(B); } }

		/// <summary></summary>
		public WLineSegment(WPoint a, WPoint b) : base(a, b)
		{
		}

		/// <summary></summary>
		public WLineSegment(WPoint a, WPoint b, bool isDirected) : base(a, b, isDirected)
		{
		}

		/// <summary>Convert to <see cref="WLine"/>.</summary>
		public WLine ToWLine()
		{
			return new WLine(A, B, IsDirected);
		}

		/// <summary>Returns true if point <paramref name='c'/> lies on this line segment.</summary>
		public override bool Overlaps(WPoint c)
		{
			if(IsVertical)
			{
				return (Geometry.WithinMarginOfError(c.X, A.X));
			}

			if(!Geometry.WithinMarginOfError(c.Y, (Slope * c.X) + YIntercept))
			{
				return false;
			}

			return (c.X >= Math.Min(A.X, B.X) && c.X <= Math.Max(A.X, B.X) 
				&& c.Y >= Math.Min(A.Y, B.Y) && c.Y <= Math.Max(A.Y, B.Y)); 
		}

		/// <summary>Returns true if this line segments overlaps line segment <paramref name='b'/> at any point.</summary>
		public bool Overlaps(WLineSegment b)
		{
			Intersection intersection = GetIntersection(b);
			return (intersection != Intersection.NONE);
		}

		/// <summary>Returns intersection between a line segment and another line segment.</summary>
		public override Intersection GetIntersection(WLineSegment that)
		{
			if(this.Parallel(that))
			{
				bool thisAOnThat = this.A.Overlaps(that);
				bool thisBOnThat = this.B.Overlaps(that);
				bool thatAOnThis = that.A.Overlaps(this);
				bool thatBOnThis = that.B.Overlaps(this);

				if(!thisAOnThat && !thisBOnThat && !thatAOnThis && !thatBOnThis)
					return Intersection.NONE;

				if(thisAOnThat && thisBOnThat)
					return new Intersection(this);

				if(thatAOnThis && thatBOnThis)
					return new Intersection(that);

				WPoint overlapThis = null;
				WPoint overlapThat = null;
				if(thisAOnThat)
					overlapThis = this.A;
				else if(thisBOnThat)
					overlapThis = this.B;
				if(thatAOnThis)
					overlapThat = that.A;
				else if(thatBOnThis)
					overlapThat = that.B;

				if(overlapThis == null || overlapThat == null)
				{
					//should not reach this, but just in case
					return Intersection.NONE;
				}

				if(overlapThis == overlapThat)
					return new Intersection(overlapThis);

				return new Intersection(new WLineSegment(overlapThis, overlapThat));
			}

			Intersection possibleIntersection = (this.ToWLine()).GetIntersection(that.ToWLine());
			if(possibleIntersection.IsPoint && this.Overlaps(possibleIntersection.Point) && that.Overlaps(possibleIntersection.Point))
				return possibleIntersection;

			return Intersection.NONE;
		}

		/// <summary>Returns intersection between a line segment and a line.</summary>
		public override Intersection GetIntersection(WLine b)
		{
			if(this.Parallel(b))
			{
				if(b.Overlaps(this.A))
					return new Intersection(this);
				return Intersection.NONE;
			}

			WLine thisLine = this.ToWLine();
			Intersection potentialIntersection = thisLine.GetIntersection(b);
			if(this.Overlaps(potentialIntersection.Point))
				return potentialIntersection;

			return Intersection.NONE;
		}

		/// <summary>Returns false. An infinite line cannot be coincidental to a finite line.</summary>
		public override bool Coincidental(WLine b)
		{
			return false;
		}

		/// <summary>Returns true if lines are coincidental to each other.</summary>
		/// <remarks>Coincidental means that every point on this line is also on the other, and vice versa. In short, the lines are equal.</remarks>
		public override bool Coincidental(WLineSegment b)
		{
			return (this.A == b.A && this.B == b.B);
		}

		/// <summary>Format "(A.x,A.y) to (B.x,B.y)"</summary>
		public override string ToString()
		{
			return String.Format("{0} to {1}", A, B);
		}

		/// <inheritdoc/>
		public void Paint(Graphics graphics, Pen pen, double unitsToPixels)
		{
			graphics.DrawLine(pen, 
				(float)(A.X * unitsToPixels),
				(float)(A.Y * unitsToPixels),
				(float)(B.X * unitsToPixels),
				(float)(B.Y * unitsToPixels)
			);
		}

		/// <summary></summary>
		public static bool operator ==(WLineSegment a, WLineSegment b)
		{
			if(object.ReferenceEquals(a, null) && object.ReferenceEquals(b, null))
				return true;
			if(object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null))
				return false;
			if(a.A == b.A && a.B == b.B)
				return true;
			if(!a.IsDirected || !b.IsDirected) //if at least one line is undirected, can try reversing one for a match
			{
				if(a.A == b.B && a.B == b.A)
					return true;
			}
			return false;
		}

		/// <summary></summary>
		public static bool operator !=(WLineSegment a, WLineSegment b)
		{
			return (!(a == b));
		}

		/// <summary></summary>
		public override bool Equals(Object b)
		{
			if(object.ReferenceEquals(b, null))
				return false;
			if(!(b is WLineSegment))
				return false;
			return (this == (WLineSegment)b);
		}

		/// <summary></summary>
		public override int GetHashCode()
		{
			return A.GetHashCode() ^ B.GetHashCode();
		}
	}
}
