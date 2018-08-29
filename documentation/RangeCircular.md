# RangeCircular

A range on a circular scale within range [0, CircularModulus). Immutable.

Base Type: [Range](Range.md)

## Fields

### Normal Fields

#### Int32 CircularModulus

The value where the range loops back to 0.

## Properties

### Double Middle

Middle value in range.

### Double Span

Length from Start to End.

## Constructors

### RangeCircular(System.Double s, System.Double e, System.Int32 mod)

## Static Methods

### RangeCircular Centered(System.Double center, System.Double span, System.Int32 mod)

Create a range with this span, middle value, and modulus.

### Double Mod(System.Double number, System.Int32 m)

Returns number modulus m. Ensures a positive result.

## Methods

### Boolean Equals(System.Object b)

### Int32 GetHashCode()

### Double Mod(System.Double number)

Convert a number into this range.

### Boolean Overlaps(RangeCircular b)

### Boolean Overlaps(System.Double b)

## Operators

### RangeCircular = (RangeCircular + RangeCircular)

Returns a range that covers all the area both A and B cover, including any gap in between.

If the ranges overlap, there is no gap filled in.

Gaps are covered from direction A to B, therefore this operation is not commutative.

### Boolean = (RangeCircular == RangeCircular)

### Boolean = (RangeCircular != RangeCircular)

