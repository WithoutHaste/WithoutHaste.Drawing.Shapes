# Wedge

A wedge (aka circular sector) is a slice of a circle.

## Properties

### Point ArcPoint

The point at the center of the arc, furthest from the center.

## Methods

### Boolean ArcOverlaps(LineSegment)

The arc is the curved circle segment part of the wedge.

### Boolean ArcOverlapsArc(Wedge)

The arc is the curved circle segment part of the wedge.

### Boolean Contains(Circle)

Circle B lies entirely within this wedge.

### Boolean Contains(Point)

This wedge contains point B, including point B being on an edge of the wedge.

### Boolean Overlaps(Circle)

Any part of this wedge overlaps any part of circle B.

### Boolean Overlaps(Wedge)

Any part of this wedge overlaps any part of wedge B.

## Operators

### Wedge = Wedge / System.Double

Scale wedge down by B amount. Affects length and location measures, but not degrees.

