# Geometry

Static type.

Global settings and miscellaneous operations.

Base Type: System.Object

## Enums

### CoordinatePlanes

Determines how cardinal directions apply to coordinates.

* None  
* Screen: Computer screens have (0,0) in the upper-left corner and increase to the right and down.  
* Paper: Paper graphs have (0,0) in the lower-left corner and increase to the right and up.  

### Direction

Cardinal directions.

* None  
* East  
* SouthEast  
* South  
* SouthWest  
* West  
* NorthWest  
* North  
* NorthEast  

## Fields

### Normal Fields

#### CoordinatePlanes CoordinatePlane

This coordinate plane is used in all Shape operations that require one.

#### Double MarginOfError

When determining equality, all values have a +/- margin of error. This setting is used in all Shape operations that check equality.

## Static Methods

### Direction LineDirection(Point a, Point b)

Given directed line A to B, what direction is it pointing?

North, South, East, and West are precise. The inbetween directions are vague.

### Point PointOnLine(Point a, Point b, System.Double distance)

Calculates point along line AB, starting at A and moving towards B

### Point PointPastLine(Point a, Point b, System.Double distance)

Calculates point along line AB, starting at B and moving away from A

### Boolean WithinMarginOfError(System.Double a, System.Double b)

Check if values are equal, within the MarginOfError.

