# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Line

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  

Line of infinite length passing through points A and B. Immutable.  

# Fields

## A

**readonly [Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

## B

**readonly [Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

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

## Line([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: Points A and B cannot be the same.  

## Line([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b, bool isDirected)

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: Points A and B cannot be the same.  

# Methods

## GetPerpendicularIntersect([Dot](WithoutHaste.Drawing.Shapes.Dot.md) c)

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Returns the point where a perpendicular line passing through point _c_ intersects this line.  

## ToLineSegment()

**[LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md)**  

Convert to [LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md).  

## ToString()

**virtual string**  

Format "(A.x,A.y) to (B.x,B.y)"  

# Operators

## Line = Line a / double b

Scale line down by _b_ amount. Affects length and location measures.  

**Example A:**  
`line / 2` returns a new Line that lies halfway between point (0,0) and this line.  

# Derived By

[WithoutHaste.Drawing.Shapes.LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md)  
Line segment from point A to point B. Immutable.  

