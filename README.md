# Raindrops

## Aim

A method which takes an integer value as its parameter and converts it to a string based on the numbers factors.

- if the number has a factor of 3, output 'Pling'
- if the number has a factor of 5, output 'Plang'
- if the number has a factor of 7, output 'Plong'
- if the number does not have any of the above as a factor simply return the numbers digits

## Examples
- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34 has four factors: 1, 2, 17, and 34: this would be '34'

## Tests

The method has been fully unit tested ensuring each combination of outputs is generated correctly as well as tests for edge cases such as negative numbers and factors of zero.

Tests included:

- FactorOf3ReturnsPling
- FactorOf5ReturnsPlang
- FactorOf7ReturnsPlong
- FactorOf3And5ReturnsPlingPlang
- FactorOf3And7ReturnsPlingPlong
- FactorOf5And7ReturnsPlangPlong
- FactorOf3And5And7ReturnsPlingPlangPlong
- ZeroReturnsPlingPlangPlong
- NoFactorOf3Or5Or7ReturnsNumberAsString