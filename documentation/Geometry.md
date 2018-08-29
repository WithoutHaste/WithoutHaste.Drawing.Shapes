# Geometry

Static type.

Miscellaneous settings and operations.

Base Type: System.Object

## Enums

### CoordinatePlanes

Determines how cardinal directions apply to coordinates.

* Screen: Computer screens have (0,0) in the upper-left corner and increase to the right and down.  
* Paper: Paper graphs have (0,0) in the lower-left corner and increase to the right and up.  

## Fields

### Normal Fields

#### Double MarginOfError

When determining equality, all values have a +- margin of error.

## Static Methods

### Direction LineDirection(Point a, Point b)

Given directed line A to B, what direction is it pointing?
            North, South, East, and West are precise. The inbetween directions are vague.

### Point PointOnLine(Point a, Point b, System.Double distance)

Calculates point along line AB, starting at A and moving towards B

### Point PointPastLine(Point a, Point b, System.Double distance)

Calculates point along line AB, starting at B and moving away from A

