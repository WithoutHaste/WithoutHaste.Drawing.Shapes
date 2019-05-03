using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// Line of infinite length passing through points A and B. Immutable.
	/// </summary>
	/// <remarks>
	/// General Form:         a*x + b*y = c
	/// Slope-Intercept Form: y = m*x + b
	/// Point-Slope Form:     y - y' = m*(x - x')
	/// Vertical Line:        x = k
	/// Horizontal Line:      y = k
	/// 
	/// Where "m" is Slope.
	/// Where "a", "b", "c", and "k" are constants.
	/// Where "a", "b", and "c" are integers and "a" > 0.
	/// </remarks>
	public class WLine : WShape
	{
		/// <summary></summary>
		public readonly WPoint A;
		/// <summary></summary>
		public readonly WPoint B;
		/// <summary>
		/// When directed, the direction is A to B.
		/// </summary>
		public readonly bool IsDirected;

		/// <summary>Slope assumes direction from A to B.</summary>
		public double Slope { get { return ((B.Y - A.Y) / (B.X - A.X)); } }
		/// <summary>Slope of line perpendicular to this one.</summary>
		public double PerpendicularSlope { get { return -1 * (1 / Slope); } }
		/// <summary></summary>
		public double YIntercept { get { return A.Y - (Slope * A.X); } }
		/// <summary></summary>
		public bool IsVertical { get { return Geometry.WithinMarginOfError(A.X, B.X); } }
		/// <summary></summary>
		public bool IsHorizontal { get { return Geometry.WithinMarginOfError(A.Y, B.Y); } }

		/// <exception cref='ArgumentException'>Points A and B cannot be the same.</exception>
		public WLine(WPoint a, WPoint b)
		{
			if(a == b)
				throw new ArgumentException("Points A and B cannot be the same.");
			A = a;
			B = b;
			IsDirected = false;
		}

		/// <exception cref='ArgumentException'>Points A and B cannot be the same.</exception>
		public WLine(WPoint a, WPoint b, bool isDirected)
		{
			if(a == b)
				throw new ArgumentException("Points A and B cannot be the same.");
			A = a;
			B = b;
			IsDirected = isDirected;
		}

		/// <summary>Generates a vertical line through the specified point.</summary>
		public static WLine Vertical(WPoint point)
		{
			return new WLine(point, new WPoint(point.X, point.Y + 1));
		}

		/// <summary>Convert to <see cref="WLineSegment"/>.</summary>
		public WLineSegment ToLineSegment()
		{
			return new WLineSegment(A, B, IsDirected);
		}
		
		//todo: verify that all line operations take vertical and horizontal lines into account

		/// <summary>
		/// Returns the point where a perpendicular line passing through point <paramref name='c'/> intersects this line.
		/// </summary>
		public WPoint GetPerpendicularIntersect(WPoint c)
		{
			if(IsVertical)
			{
				return new WPoint(this.A.X, c.Y);
			}
			if(IsHorizontal)
			{
				return new WPoint(c.X, this.A.Y);
			}
			double cSlope = PerpendicularSlope;
			double cYIntercept = c.Y - (cSlope * c.X);
			double x = (cYIntercept - this.YIntercept) / (this.Slope - cSlope);
			double y = (this.Slope * x) + this.YIntercept;
			return new WPoint(x, y);
		}

		/// <summary>Returns true if point <paramref name='c'/> lies on this line.</summary>
		public virtual bool Overlaps(WPoint c)
		{
			if(IsVertical)
			{
				return (Geometry.WithinMarginOfError(c.X, A.X));
			}

			if(!Geometry.WithinMarginOfError(c.Y, (Slope * c.X) + YIntercept))
			{
				return false;
			}

			return true;
		}

		/// <summary>Returns the intersection between the two lines.</summary>
		public virtual Intersection GetIntersection(WLine b)
		{
			if(this.Parallel(b))
			{
				if(this.Coincidental(b))
					return new Intersection(this);
				return Intersection.NONE;
			}
			//y = mx + b AND y = m'x + b'
			//mx + b = m'x + b'
			//mx - m'x = b' - b
			//x(m - m') = b' - b
			//x = (b' - b) / (m - m')
			double intersectionX = (b.YIntercept - this.YIntercept) / (this.Slope - b.Slope);
			if(this.IsVertical)
				intersectionX = this.A.X;
			else if(b.IsVertical)
				intersectionX = b.A.X;
			//y = mx + b
			double intersectionY = (this.Slope * intersectionX) + this.YIntercept;
			if(this.IsVertical)
				intersectionY = (b.Slope * intersectionX) + b.YIntercept;
			else if(this.IsHorizontal)
				intersectionY = this.A.Y;
			if(b.IsHorizontal)
				intersectionY = b.A.Y;

			return new Intersection(new WPoint(intersectionX, intersectionY));
		}

		/// <summary>Returns intersection between a line segment and a line.</summary>
		public virtual Intersection GetIntersection(WLineSegment b)
		{
			return b.GetIntersection(this);
		}

		/// <summary>Returns true if the lines are parallel to each other.</summary>
		/// <remarks>Parallel means they have the same slope.</remarks>
		public bool Parallel(WLine b)
		{
			return Geometry.WithinMarginOfError(this.Slope, b.Slope);
		}

		/// <summary>Returns true if lines are coincidental to each other.</summary>
		/// <remarks>Coincidental means that every point on this line is also on the other, and vice versa. In short, the lines are equal.</remarks>
		public virtual bool Coincidental(WLine b)
		{
			return (Parallel(b) && Geometry.WithinMarginOfError(this.YIntercept, b.YIntercept));
		}

		/// <summary>Returns false. An infinite line cannot be coincidental to a finite line.</summary>
		public virtual bool Coincidental(WLineSegment b)
		{
			return false;
		}

		/// <summary>
		/// Scale line down by <paramref name='b'/> amount. Affects length and location measures.
		/// </summary>
		/// <example><c>line / 2</c> returns a new Line that lies halfway between point (0,0) and this line.</example>
		public static WLine operator /(WLine a, double b)
		{
			return new WLine(a.A / b, a.B / b);
		}

		/// <summary>Format "(A.x,A.y) to (B.x,B.y)"</summary>
		public override string ToString()
		{
			return String.Format("{0} to {1}", A, B);
		}
	}
}
