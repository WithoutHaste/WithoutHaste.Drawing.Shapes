# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WWedgeUnbound

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  

A wedge is a slice of a circle. An unbounded wedge is a slice of circle that extends outward from the center with no limit. Immutable.  

# Fields

## Center

**readonly [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Center of the circle that defines this wedge.  

## Degrees

**readonly [WRangeCircular](WithoutHaste.Drawing.Shapes.WRangeCircular.md)**  

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

## WWedgeUnbound([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) center, [WRangeCircular](WithoutHaste.Drawing.Shapes.WRangeCircular.md) degreeRange)

## WWedgeUnbound([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) center, double degreesRangeStart, double degreesRangeEnd)

# Derived By

[WithoutHaste.Drawing.Shapes.WWedge](WithoutHaste.Drawing.Shapes.WWedge.md)  
A wedge is a slice of a circle. It is also known as a circular sector. Immutable.  

