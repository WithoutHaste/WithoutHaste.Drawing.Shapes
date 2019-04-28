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
		public WLine ToLine()
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

		///// <summary>Returns intersection between a line segment and another line segment.</summary>
		//public override Intersection GetIntersection(WLineSegment b)
		//{
		//	if(this.Parallel(b))
		//	{
		//		if(this.A == b.A)
		//		{
		//			if(this.B.Overlaps(b))
		//				return new Intersection(this);
		//			if(b.B.Overlaps(this))
		//				return new Intersection(b);
		//			return new Intersection(this.A);
		//		}
		//		else if(this.A == b.B)
		//		{
		//			if(this.B.Overlaps(b))
		//				return new Intersection(this);
		//			if(b.A.Overlaps(this))
		//				return new Intersection(b);
		//			return new Intersection(this.A);
		//		}
		//		//TODO cont rewrite
		//	}

		//	////line may lie over the line segment
		//	////line equation: y = mx + b, where m is slope and b is y-intercept
		//	//double slopeA = this.Slope;
		//	//double slopeB = b.Slope;
		//	//if(Geometry.WithinMarginOfError(slopeA, slopeB))
		//	//{
		//	//	//parallel lines don't overlap unless they are right on top of each other
		//	//	//meaning, one of the points must be on the other line
		//	//	if(b.Overlaps(this.A) || b.Overlaps(this.B) || this.Overlaps(b.A) || this.Overlaps(b.B))
		//	//		return new Intersection(this);
		//	//	//parallel lines didn't touch
		//	//	return Intersection.NONE;
		//	//}

		//	////line may intersect at 1 point
		//	//double x = (b.YIntercept - this.YIntercept) / (this.Slope - b.Slope);
		//	//if(this.IsVertical)
		//	//{
		//	//	x = this.A.X;
		//	//}
		//	//else if(b.IsVertical)
		//	//{
		//	//	x = b.A.X;
		//	//}
		//	//double y = (this.Slope * x) + this.YIntercept;
		//	//if(this.IsHorizontal)
		//	//{
		//	//	y = this.A.Y;
		//	//}
		//	//else if(b.IsHorizontal)
		//	//{
		//	//	y = b.A.Y;
		//	//}
		//	//WPoint interceptPoint = new WPoint(x, y);
		//	//if(this.Overlaps(interceptPoint) && b.Overlaps(interceptPoint))
		//	//	return new Intersection(interceptPoint);

		//	////no intersection
		//	//return Intersection.NONE;
		//}

		/// <summary>Returns intersection between a line segment and a line.</summary>
		public override Intersection GetIntersection(WLine b)
		{
			if(this.Parallel(b))
			{
				if(b.Overlaps(this.A))
					return new Intersection(this);
				return Intersection.NONE;
			}

			WLine thisLine = this.ToLine();
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
	}
}
