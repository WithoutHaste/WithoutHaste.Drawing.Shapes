# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Wedge

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md) → [WedgeUnbound](WithoutHaste.Drawing.Shapes.WedgeUnbound.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

A wedge is a slice of a circle. It is also known as a circular sector. Immutable.  

# Fields

## Radius

**readonly double**  

# Properties

## ArcPoint

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

The point at the middle of the arc.  

## Circle

**[Circle](WithoutHaste.Drawing.Shapes.Circle.md) { public get; }**  

Full circle that this Wedge is a part of.  

## EndPoint

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

Point on circumference of Circle where Wedge ends.  

## FourPoints

**[Dot[]](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

* The boundary points of the Wedge:  
* the center of the circle  
* StartPoint  
* EndPoint  
* ArcPoint  

## LineEdges

**[LineSegment[]](WithoutHaste.Drawing.Shapes.LineSegment.md) { public get; }**  

* The straight edges of the Wedge:  
* Center to StartPoint  
* Center to EndPoint  

## MaxX

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## MaxY

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## StartPoint

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

Point on circumference of Circle where Wedge begins.  

# Constructors

## Wedge([Circle](WithoutHaste.Drawing.Shapes.Circle.md) circle, [RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md) radius)

## Wedge([Circle](WithoutHaste.Drawing.Shapes.Circle.md) circle, double rangeStart, double rangeEnd)

# Methods

## ArcOverlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) line)

**bool**  

The arc is the curved circle segment part of the wedge.  

## ArcOverlapsArc([Wedge](WithoutHaste.Drawing.Shapes.Wedge.md) b)

**bool**  

The arc is the curved circle segment part of the wedge.  

## Contains([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

Circle B lies entirely within this wedge.  

## Contains([Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**bool**  

This wedge contains point B, including point B being on an edge of the wedge.  

## Overlaps([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

Any part of this wedge overlaps any part of circle B.  

## Overlaps([Wedge](WithoutHaste.Drawing.Shapes.Wedge.md) b)

**bool**  

Any part of this wedge overlaps any part of wedge B.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## ToString()

**virtual string**  

# Operators

## Wedge = Wedge a / double b

Scale wedge down by B amount. Affects length and location measures, but not degrees.  

