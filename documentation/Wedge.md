# Wedge

A wedge is a slice of a circle. It is also known as a circular sector. Immutable.

Base Type: [WedgeUnbound](WedgeUnbound.md)

## Fields

### Normal Fields

#### Double Radius

## Properties

### Point ArcPoint

The point at the middle of the arc.

### Circle Circle

Full circle that this Wedge is a part of.

### Point EndPoint

Point on circumference of Circle where Wedge ends.

### Point[] FourPoints

The boundary points of the Wedge:  
* the center of the circle  
* StartPoint  
* EndPoint  
* ArcPoint  

### LineSegment[] LineEdges

The straight edges of the Wedge:  
* Center to StartPoint  
* Center to EndPoint  

### Double MaxX

See [IDraw](IDraw.md).

### Double MaxY

See [IDraw](IDraw.md).

### Point StartPoint

Point on circumference of Circle where Wedge begins.

## Constructors

### Wedge(Circle circle, RangeCircular radius)

### Wedge(Circle circle, System.Double rangeStart, System.Double rangeEnd)

## Methods

### Boolean ArcOverlaps(LineSegment line)

The arc is the curved circle segment part of the wedge.

### Boolean ArcOverlapsArc(Wedge b)

The arc is the curved circle segment part of the wedge.

### Boolean Contains(Circle b)

Circle B lies entirely within this wedge.

### Boolean Contains(Point b)

This wedge contains point B, including point B being on an edge of the wedge.

### Boolean Overlaps(Circle b)

Any part of this wedge overlaps any part of circle B.

### Boolean Overlaps(Wedge b)

Any part of this wedge overlaps any part of wedge B.

### Void Paint(System.Drawing.Graphics graphics, System.Drawing.Pen pen, System.Double unitsToPixels)

See [IDraw](IDraw.md).

### String ToString()

## Operators

### Wedge = (Wedge / System.Double)

Scale wedge down by B amount. Affects length and location measures, but not degrees.

