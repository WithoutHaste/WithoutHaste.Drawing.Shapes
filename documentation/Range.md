# Range

A linear range of values. Immutable.

Base Type: [Shape](Shape.md)

## Fields

### Normal Fields

#### Double End

#### Double Start

For non-circular ranges, operations assume that Start is the minimum value.

## Properties

### Double Middle

Middle value between Start and End.

### Double Span

End minus Start.

## Constructors

### Range(System.Double start, System.Double end)

## Static Methods

### Range Centered(System.Double middle, System.Double span)

Create a range with this span and middle value.

### Double ConvertValue(Range originalRange, Range newRange, System.Double value)

Convert a value in originalRange to one in newRange, assuming that the original range is re-scaled to the new range.

## Methods

### Boolean Equals(System.Object b)

### Int32 GetHashCode()

### Boolean Overlaps(Range b)

### Boolean Overlaps(System.Double b)

### String ToString()

Format "start-end"

## Operators

### Range = (Range + Range)

Returns a range that covers all the area both A and B cover, including any gap in between.

This operation is commutative.

### Boolean = (Range == Range)

### Boolean = (Range != Range)

