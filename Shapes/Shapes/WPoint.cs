using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// An (X, Y) coordinate. Immutable.
	/// </summary>
	public class WPoint : WShape, IDraw
	{
		/// <summary></summary>
		public readonly double X;
		/// <summary></summary>
		public readonly double Y;

		/// <inheritdoc/>
		public double MaxX { get { return X; } }
		/// <inheritdoc/>
		public double MaxY { get { return Y; } }

		/// <param name="x">Cannot be NaN or Infinity.</param>
		/// <param name="y">Cannot be NaN or Infinity.</param>
		/// <exception cref="ArgumentException">X or Y was NaN or Infinity.</exception>
		public WPoint(double x, double y)
		{
			if(double.IsNaN(x))
				throw new ArgumentException("Point.X cannot be NaN."); //todo: specific exceptions
			if(double.IsNaN(y))
				throw new ArgumentException("Point.Y cannot be NaN.");
			if(double.IsInfinity(x))
				throw new ArgumentException("Point.X cannot be +/- Infinity.");
			if(double.IsInfinity(y))
				throw new ArgumentException("Point.Y cannot be +/- Infinity.");
			X = x;
			Y = y;
		}

		/// <summary>
		/// Returns the distance between this point and point <paramref name='b'/>. Always positive.
		/// </summary>
		public double Distance(WPoint b)
		{
			return Math.Sqrt(Math.Pow(b.X - this.X, 2) + Math.Pow(b.Y - this.Y, 2));
		}

		/// <summary>Returns true if this point overlaps any part of the <pararef name='lineSegment'/>.</summary>
		public bool Overlaps(WLineSegment lineSegment)
		{
			return lineSegment.Overlaps(this);
		}

		/// <summary></summary>
		public static WPoint operator +(WPoint a, WPoint b)
		{
			return new WPoint(a.X + b.X, a.Y + b.Y);
		}

		/// <summary></summary>
		public static WPoint operator -(WPoint a, WPoint b)
		{
			return new WPoint(a.X - b.X, a.Y - b.Y);
		}

		/// <summary></summary>
		public static WPoint operator *(double a, WPoint b)
		{
			return new WPoint(a * b.X, a * b.Y);
		}

		/// <summary></summary>
		public static WPoint operator *(WPoint a, double b)
		{
			return new WPoint(a.X * b, a.Y * b);
		}

		/// <summary></summary>
		public static WPoint operator /(double a, WPoint b)
		{
			return new WPoint(a / b.X, a / b.Y);
		}

		/// <summary></summary>
		public static WPoint operator /(WPoint a, double b)
		{
			return new WPoint(a.X / b, a.Y / b);
		}

		/// <summary>
		/// Greater than/less than is judged along the x-axis first, then the y-axis
		/// </summary>
		public static bool operator <(WPoint a, WPoint b)
		{
			return (a.X < b.X || (a.X == b.X && a.Y < b.Y));
		}

		/// <duplicate cref='op_LessThan(WPoint,WPoint)'/>
		public static bool operator >(WPoint a, WPoint b)
		{
			return (a.X > b.X || (a.X == b.X && a.Y > b.Y));
		}

		/// <summary></summary>
		public static bool operator ==(WPoint a, WPoint b)
		{
			return (Geometry.WithinMarginOfError(a.X, b.X) && Geometry.WithinMarginOfError(a.Y, b.Y));
		}

		/// <summary></summary>
		public static bool operator !=(WPoint a, WPoint b)
		{
			return (!Geometry.WithinMarginOfError(a.X, b.X) || !Geometry.WithinMarginOfError(a.Y, b.Y));
		}

		/// <summary></summary>
		public override bool Equals(Object b)
		{
			if(b != null && b is WPoint)
			{
				return (this == (WPoint)b);
			}
			return false;
		}

		/// <summary></summary>
		public override int GetHashCode()
		{
			return X.GetHashCode() ^ Y.GetHashCode();
		}

		/// <summary>Format "(X,Y)"</summary>
		public override string ToString()
		{
			return String.Format("({0},{1})", X, Y);
		}

		/// <inheritdoc/>
		public void Paint(Graphics graphics, Pen pen, double unitsToPixels)
		{
			graphics.DrawArc(pen, 
				(float)((X - 1) * unitsToPixels), 
				(float)((Y - 1) * unitsToPixels), 
				(float)(2 * unitsToPixels), 
				(float)(2 * unitsToPixels), 
				0, 
				WCircle.DEGREES_IN_CIRCLE); 
		}
	}
}
