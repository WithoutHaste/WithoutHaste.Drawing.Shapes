# Geometry

Miscellaneous settings and operations.

## Enums

### CoordinatePlanes

Determines how cardinal directions apply to coordinates.

* Screen: Computer screens have (0,0) in the upper-left corner and increase to the right and down.  
* Paper: Paper graphs have (0,0) in the lower-left corner and increase to the right and up.  

## Fields

### MarginOfError

When determining equality, all values have a +- margin of error.

## Methods

### LineDirection(Point, Point)

Given directed line A to B, what direction is it pointing?
            North, South, East, and West are precise. The inbetween directions are vague.

### PointOnLine(Point, Point, System.Double)

Calculates point along line AB, starting at A and moving towards B

### PointPastLine(Point, Point, System.Double)

Calculates point along line AB, starting at B and moving away from A

