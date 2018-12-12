# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WedgeUnbound

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  

A wedge is a slice of a circle. An unbounded wedge is a slice of circle that extends outward from the center with no limit. Immutable.  

# Fields

## Center

**readonly [Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Center of the circle that defines this wedge.  

## Degrees

**readonly [RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md)**  

The degrees of the defining circle that this wedge extends through.  

# Properties

## End

**double { public get; }**  

Ending degree.  

## Span

**double { public get; }**  

The total degrees this wedge covers.  

## Start

**double { public get; }**  

Starting degree.  

# Constructors

## WedgeUnbound([Dot](WithoutHaste.Drawing.Shapes.Dot.md) center, [RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md) degreeRange)

## WedgeUnbound([Dot](WithoutHaste.Drawing.Shapes.Dot.md) center, double degreesRangeStart, double degreesRangeEnd)

# Derived By

[WithoutHaste.Drawing.Shapes.Wedge](WithoutHaste.Drawing.Shapes.Wedge.md)  
A wedge is a slice of a circle. It is also known as a circular sector. Immutable.  

