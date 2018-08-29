# Range

A linear range of values.

## Fields

### Start

For non-circular ranges, operations assume that Start is the minimum value.

## Methods

### ConvertValue(Range, Range, System.Double)

Convert a value in originalRange to one in newRange, assuming that the original range is re-scaled to the new range.

### op_Addition(Range, Range)

Returns a range that covers all the area both A and B cover, including any gap in between.
            This operation is commutative.
