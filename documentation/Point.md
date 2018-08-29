# Point

Represents an (X, Y) point.

Immutable.

Derived from the `Shape` class and `IDraw` interface.  
(Interface properties and methods are not included here.)  

## Properties

`double X`: x coordinate  
`double Y`: y coordinate  

## Constructor

`new Point(double x, double y)`

Coordinates cannot be `NaN` nor `Infinity`.

## Methods

### Distance

Returns the distance between this Point and Point B.

`double distance = point.Distance(Point b);`

### Overlaps

Returns true if this Point is on the LineSegment.

`bool onLine = point.Overlaps(LineSegment);`

## Operators

Point = Point + Point: sums the x's and y's  
Point = Point - Point: minus the x's and y's  

Point = double * Point: multiplies the double by each coordinate  
Point = Point * double: multiplies the double by each coordinates  

Point = double / Point: the double divided by each coordinate  
Point = Point / double: each coordinate divided by the double  

Point < Point: determined along the x-axis, then the y-axis  
Point > Point: determined along the x-axis, then the y-axis  
Point == Point  
Point != Point  
