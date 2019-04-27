# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WLine

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  

Line of infinite length passing through points A and B. Immutable.  

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

## GetPerpendicularIntersect([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) c)

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Returns the point where a perpendicular line passing through point _c_ intersects this line.  

## ToLineSegment()

**[WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md)**  

Convert to [WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md).  

## ToString()

**virtual string**  

Format "(A.x,A.y) to (B.x,B.y)"  

# Operators

## WLine = WLine a / double b

Scale line down by _b_ amount. Affects length and location measures.  

**Example A:**  
`line / 2` returns a new Line that lies halfway between point (0,0) and this line.  

# Derived By

[WithoutHaste.Drawing.Shapes.WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md)  
Line segment from point A to point B. Immutable.  

