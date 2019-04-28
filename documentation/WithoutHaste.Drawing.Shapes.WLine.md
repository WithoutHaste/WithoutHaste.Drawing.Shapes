# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WLine

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  

Line of infinite length passing through points A and B. Immutable.  

**Remarks:**  
General Form:         a*x + b*y = c  
Slope-Intercept Form: y = m*x + b  
Point-Slope Form:     y - y' = m*(x - x')  
Vertical Line:        x = k  
Horizontal Line:      y = k  
  
Where "m" is Slope.  
Where "a", "b", "c", and "k" are constants.  
Where "a", "b", and "c" are integers and "a" &gt; 0.  

# Fields

## A

**readonly [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

## B

**readonly [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

## IsDirected

**readonly bool**  

When directed, the direction is A to B.  

# Properties

## IsHorizontal

**bool { public get; }**  

## IsVertical

**bool { public get; }**  

## PerpendicularSlope

**double { public get; }**  

Slope of line perpendicular to this one.  

## Slope

**double { public get; }**  

Slope assumes direction from A to B.  

## YIntercept

**double { public get; }**  

# Constructors

## WLine([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) a, [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b)

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: Points A and B cannot be the same.  

## WLine([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) a, [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b, bool isDirected)

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: Points A and B cannot be the same.  

# Methods

## Coincidental([WLine](WithoutHaste.Drawing.Shapes.WLine.md) b)

**virtual bool**  

Returns true if lines are coincidental to each other.  

**Remarks:**  
Coincidental means that every point on this line is also on the other, and vice versa. In short, the lines are equal.  

## Coincidental([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) b)

**virtual bool**  

Returns false. An infinite line cannot be coincidental to a finite line.  

## GetIntersection([WLine](WithoutHaste.Drawing.Shapes.WLine.md) b)

**virtual [Intersection](WithoutHaste.Drawing.Shapes.Intersection.md)**  

Returns the intersection between the two lines.  

## GetIntersection([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) b)

**virtual [Intersection](WithoutHaste.Drawing.Shapes.Intersection.md)**  

Returns intersection between a line segment and a line.  

## GetPerpendicularIntersect([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) c)

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Returns the point where a perpendicular line passing through point _c_ intersects this line.  

## Overlaps([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) c)

**virtual bool**  

Returns true if point _c_ lies on this line.  

## Parallel([WLine](WithoutHaste.Drawing.Shapes.WLine.md) b)

**bool**  

Returns true if the lines are parallel to each other.  

**Remarks:**  
Parallel means they have the same slope.  

## ToLineSegment()

**[WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md)**  

Convert to [WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md).  

## ToString()

**virtual string**  

Format "(A.x,A.y) to (B.x,B.y)"  

# Static Methods

## Vertical([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) point)

**static WLine**  

Generates a vertical line through the specified point.  

# Operators

## WLine = WLine a / double b

Scale line down by _b_ amount. Affects length and location measures.  

**Example A:**  
`line / 2` returns a new Line that lies halfway between point (0,0) and this line.  

# Derived By

[WithoutHaste.Drawing.Shapes.WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md)  
Line segment from point A to point B. Immutable.  

