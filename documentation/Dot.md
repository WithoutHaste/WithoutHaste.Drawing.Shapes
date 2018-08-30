# Dot

An (X, Y) coordinate. Immutable.

It's called "Dot" so as not to conflict with System.Drawing.Point. Points use integer coordinates, these Dots use doubles.

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

### Dot(System.Double x, System.Double y)

Parameter x: Cannot be NaN or Infinity.  
Parameter y: Cannot be NaN or Infinity.  

ArgumentException: X or Y was NaN or Infinity.

## Methods

### Double Distance(Dot b)

Distance between this point and point B.

### Boolean Equals(System.Object b)

### Int32 GetHashCode()

### Boolean Overlaps(LineSegment line)

### Void Paint(System.Drawing.Graphics graphics, System.Drawing.Pen pen, System.Double unitsToPixels)

See [IDraw](IDraw.md).

### String ToString()

Format "(X,Y)"

## Operators

### Dot = (Dot + Dot)

### Dot = (System.Double / Dot)

### Dot = (Dot / System.Double)

### Boolean = (Dot == Dot)

### Boolean = (Dot > Dot)

Greater than/less than is judged along the x-axis first, then the y-axis

### Boolean = (Dot != Dot)

### Boolean = (Dot < Dot)

Greater than/less than is judged along the x-axis first, then the y-axis

### Dot = (System.Double * Dot)

### Dot = (Dot * System.Double)

### Dot op_Subtraction(Dot a, Dot b)

