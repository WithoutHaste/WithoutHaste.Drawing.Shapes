# Point

An (X, Y) coordinate. Immutable.

Base Type: [Shape](Shape.md)

## Fields

### Normal Fields

#### Double X

#### Double Y

## Properties

### Double MaxX

See [IDraw](IDraw.md).

### Double MaxY

See [IDraw](IDraw.md).

## Constructors

### Point(System.Double x, System.Double y)

Parameter x: Cannot be NaN or Infinity.
Parameter y: Cannot be NaN or Infinity.

ArgumentException: X or Y was NaN or Infinity.

## Methods

### Double Distance(Point b)

Distance between this point and point B.

### Boolean Equals(System.Object b)

### Int32 GetHashCode()

### Boolean Overlaps(LineSegment line)

### Void Paint(System.Drawing.Graphics graphics, System.Drawing.Pen pen, System.Double unitsToPixels)

See [IDraw](IDraw.md).

### String ToString()

Format "(X,Y)"

## Operators

### Point = (Point + Point)

### Point = (System.Double / Point)

### Point = (Point / System.Double)

### Boolean = (Point == Point)

### Boolean = (Point > Point)

Greater than/less than is judged along the x-axis first, then the y-axis

### Boolean = (Point != Point)

### Boolean = (Point < Point)

Greater than/less than is judged along the x-axis first, then the y-axis

### Point = (System.Double * Point)

### Point = (Point * System.Double)

### Point op_Subtraction(Point a, Point b)

