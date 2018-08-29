# LineSegment

Line segment from point A to point B.

Base Type: [Line](Line.md)

## Properties

### Double Length

### Double MaxX

See [IDraw](IDraw.md).

### Double MaxY

See [IDraw](IDraw.md).

## Constructors

### LineSegment(Point a, Point b)

### LineSegment(Point a, Point b, System.Boolean isDirected)

## Methods

### Boolean Overlaps(Point c)

### Boolean Overlaps(LineSegment b)

### Void Paint(System.Drawing.Graphics graphics, System.Drawing.Pen pen, System.Double unitsToPixels)

See [IDraw](IDraw.md).

### Line ToLine()

Convert to [Line](Line.md).

### String ToString()

Format "(x,y) to (x,y)"

