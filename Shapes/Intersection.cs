using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Drawing.Shapes
{
	/// <summary>
	/// How two shapes intersected each other.
	/// </summary>
	public class Intersection
	{
		/// <summary>Constant value for "no intersection".</summary>
		public static readonly Intersection NONE = new Intersection();

		/// <summary></summary>
		public enum IntersectionType {
			/// <summary>No intersection.</summary>
			None,
			/// <summary>Intersection at a single point.</summary>
			Point,
			/// <summary>Intersection at multiple points.</summary>
			Points,
			/// <summary>Intersection along an entire line segment.</summary>
			LineSegment,
			/// <summary>Lines are coincidental.</summary>
			Line
		};

		/// <summary></summary>
		public readonly IntersectionType Type;

		#region Properties

		/// <summary></summary>
		public bool IsNone { get { return (Type == IntersectionType.None); } }
		/// <summary></summary>
		public bool IsPoint { get { return (Type == IntersectionType.Point); } }
		/// <summary></summary>
		public bool IsPoints { get { return (Type == IntersectionType.Points); } }
		/// <summary></summary>
		public bool IsLineSegment { get { return (Type == IntersectionType.LineSegment); } }
		/// <summary></summary>
		public bool IsLine { get { return (Type == IntersectionType.Line); } }

		private List<WPoint> points;
		/// <summary></summary>
		public WPoint Point {
			get {
				if(Type != IntersectionType.Point) throw new Exception("Wrong intersection type.");
				return points[0];
			}
		}
		/// <summary></summary>
		public WPoint[] Points {
			get {
				if(Type != IntersectionType.Points) throw new Exception("Wrong intersection type.");
				return points.ToArray();
			}
		}

		private WLineSegment lineSegment;
		/// <summary></summary>
		public WLineSegment LineSegment{
			get {
				if(Type != IntersectionType.LineSegment) throw new Exception("Wrong intersection type.");
				return lineSegment;
			}
		}

		private WLine line;
		/// <summary></summary>
		public WLine Line {
			get {
				if(Type != IntersectionType.Line) throw new Exception("Wrong intersection type.");
				return line;
			}
		}

		#endregion

		#region Constructors

		/// <summary></summary>
		private Intersection()
		{
			Type = IntersectionType.None;
		}

		/// <summary></summary>
		public Intersection(WPoint point)
		{
			Type = IntersectionType.Point;
			this.points = new List<WPoint>() { point };
		}

		/// <summary></summary>
		public Intersection(params WPoint[] points)
		{
			if(points.Length <= 1)
				throw new ArgumentException("At least 2 points expected.");
			Type = IntersectionType.Points;
			this.points = points.ToList();
		}

		/// <summary></summary>
		public Intersection(WLineSegment lineSegment)
		{
			Type = IntersectionType.LineSegment;
			this.lineSegment = lineSegment;
		}

		/// <summary></summary>
		public Intersection(WLine line)
		{
			Type = IntersectionType.Line;
			this.line = line;
		}

		#endregion

		/// <summary></summary>
		public override string ToString()
		{
			if(IsNone) return "NONE";
			if(IsPoint) return Point.ToString();
			if(IsPoints) return Points.ToString();
			if(IsLineSegment) return LineSegment.ToString();
			if(IsLine) return Line.ToString();
			return "UNKNOWN";
		}
	}
}
