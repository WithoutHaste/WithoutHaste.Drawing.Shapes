# LineSegment

Line segment from point A to point B. Immutable.

Base Type: [Line](Line.md)

## Properties

### Double Length

### Double MaxX

See [IDraw](IDraw.md).

### Double MaxY

See [IDraw](IDraw.md).

## Constructors

### LineSegment(Dot a, Dot b)

### LineSegment(Dot a, Dot b, System.Boolean isDirected)

## Methods

### Boolean Overlaps(Dot c)

### Boolean Overlaps(LineSegment b)

### Void Paint(System.Drawing.Graphics graphics, System.Drawing.Pen pen, System.Double unitsToPixels)

See [IDraw](IDraw.md).

### Line ToLine()

Convert to [Line](Line.md).

### String ToString()

Format "(x,y) to (x,y)"

