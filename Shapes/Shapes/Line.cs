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
	public class Line : Shape
	{
		/// <summary></summary>
		public readonly Dot A;
		/// <summary></summary>
		public readonly Dot B;
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
		public bool IsVertical { get { return (A.X == B.X); } }
		/// <summary></summary>
		public bool IsHorizontal { get { return (A.Y == B.Y); } }

		/// <exception cref='ArgumentException'>Points A and B cannot be the same.</exception>
		public Line(Dot a, Dot b)
		{
			if(a == b)
				throw new ArgumentException("Points A and B cannot be the same.");
			A = a;
			B = b;
			IsDirected = false;
		}

		/// <exception cref='ArgumentException'>Points A and B cannot be the same.</exception>
		public Line(Dot a, Dot b, bool isDirected)
		{
			if(a == b)
				throw new ArgumentException("Points A and B cannot be the same.");
			A = a;
			B = b;
			IsDirected = isDirected;
		}

		/// <summary>Convert to <see cref="LineSegment"/>.</summary>
		public LineSegment ToLineSegment()
		{
			return new LineSegment(A, B, IsDirected);
		}
		
		//todo: verify that all line operations take vertical and horizontal lines into account

		/// <summary>
		/// Returns the point where a perpendicular line passing through point <paramref name='c'/> intersects this line.
		/// </summary>
		public Dot GetPerpendicularIntersect(Dot c)
		{
			if(IsVertical)
			{
				return new Dot(this.A.X, c.Y);
			}
			if(IsHorizontal)
			{
				return new Dot(c.X, this.A.Y);
			}
			double cSlope = PerpendicularSlope;
			double cYIntercept = c.Y - (cSlope * c.X);
			double x = (cYIntercept - this.YIntercept) / (this.Slope - cSlope);
			double y = (this.Slope * x) + this.YIntercept;
			return new Dot(x, y);
		}

		/// <summary>
		/// Scale line down by <paramref name='b'/> amount. Affects length and location measures.
		/// </summary>
		/// <example><c>line / 2</c> returns a new Line that lies halfway between point (0,0) and this line.</example>
		public static Line operator /(Line a, double b)
		{
			return new Line(a.A / b, a.B / b);
		}

		/// <summary>Format "(A.x,A.y) to (B.x,B.y)"</summary>
		public override string ToString()
		{
			return String.Format("{0} to {1}", A, B);
		}
	}
}
