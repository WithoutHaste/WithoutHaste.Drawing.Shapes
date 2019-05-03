# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Intersection

**Inheritance:** object  

How two shapes intersected each other.  

# Enums

**[IntersectionType](WithoutHaste.Drawing.Shapes.Intersection.IntersectionType.md)**  
  

* 0: None  
* 1: Point  
* 2: Points  
* 3: LineSegment  
* 4: Line  

# Fields

## NONE

**const Intersection**  

Constant value for "no intersection".  

## Type

**readonly [IntersectionType](WithoutHaste.Drawing.Shapes.Intersection.IntersectionType.md)**  

# Properties

## IsLine

**bool { public get; }**  

## IsLineSegment

**bool { public get; }**  

## IsNone

**bool { public get; }**  

## IsPoint

**bool { public get; }**  

## IsPoints

**bool { public get; }**  

## Line

**[WLine](WithoutHaste.Drawing.Shapes.WLine.md) { public get; }**  

## LineSegment

**[WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) { public get; }**  

## Point

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

## Points

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

# Constructors

## Intersection()

## Intersection([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) point)

## Intersection([WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md) points)

## Intersection([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) lineSegment)

## Intersection([WLine](WithoutHaste.Drawing.Shapes.WLine.md) line)

# Methods

## ToString()

**virtual string**  

# Nested Types

[IntersectionType](WithoutHaste.Drawing.Shapes.Intersection.IntersectionType.md)  
  

