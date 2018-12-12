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

## Line([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b, bool isDirected)

# Methods

## GetPerpendicularIntersect([Dot](WithoutHaste.Drawing.Shapes.Dot.md) c)

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Get the point where a perpendicular line passing through point C intersects this line.  

## ToLineSegment()

**[LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md)**  

Convert to [LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md).  

## ToString()

**virtual string**  

Format "(x,y) to (x,y)"  

# Operators

## Line = Line a / double b

Scale line down by B amount. Affects length and location measures.  

# Derived By

[WithoutHaste.Drawing.Shapes.LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md)  
Line segment from point A to point B. Immutable.  

