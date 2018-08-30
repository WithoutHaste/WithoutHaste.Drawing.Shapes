# Line

Line of infinite length passing through points A and B. Immutable.

Base Type: [Shape](Shape.md)

## Fields

### Normal Fields

#### Dot A

#### Dot B

#### Boolean IsDirected

When directed, the direction is A to B.

## Properties

### Boolean IsHorizontal

### Boolean IsVertical

### Double PerpendicularSlope

Slope of line perpendicular to this one.

### Double Slope

Slope assumes direction from A to B.

### Double YIntercept

## Constructors

### Line(Dot a, Dot b)

### Line(Dot a, Dot b, System.Boolean isDirected)

## Methods

### Dot GetPerpendicularIntersect(Dot c)

Get the point where a perpendicular line passing through point C intersects this line.

### LineSegment ToLineSegment()

Convert to [LineSegment](LineSegment.md).

### String ToString()

Format "(x,y) to (x,y)"

## Operators

### Line = (Line / System.Double)

Scale line down by B amount. Affects length and location measures.

