# RangeCircular

A circular range of values.

## Methods

### Mod(System.Double, System.Int32)

Returns number modulus m. Ensures a positive result.

### op_Addition(RangeCircular, RangeCircular)

Returns a range that covers all the area both A and B cover, including any gap in between.
            If the ranges overlap, there is no gap filled in.
            Gaps are covered from direction A to B, therefore this operation is not commutative.

