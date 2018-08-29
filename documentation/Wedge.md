# Wedge

A wedge (aka circular sector) is a slice of a circle.

## Methods

### ArcOverlaps(LineSegment)

The arc is the curved circle segment part of the wedge.

### ArcOverlapsArc(Wedge)

The arc is the curved circle segment part of the wedge.

### Contains(Circle)

Circle B lies entirely within this wedge.

### Contains(Point)

This wedge contains point B, including point B being on an edge of the wedge.

### op_Division(Wedge, System.Double)

Scale wedge down by B amount. Affects length and location measures, but not degrees.

### Overlaps(Circle)

Any part of this wedge overlaps any part of circle B.

### Overlaps(Wedge)

Any part of this wedge overlaps any part of wedge B.

