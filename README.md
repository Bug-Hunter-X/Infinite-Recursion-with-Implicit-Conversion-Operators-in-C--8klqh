# Infinite Recursion with Implicit Conversion Operators in C#

This repository demonstrates a subtle bug in C# that can occur when using implicit conversion operators.  The bug involves an infinite recursion that arises from the interaction of custom implicit type conversions and arithmetic operations.

## Bug Description

A custom class, `MyClass`, is defined with implicit conversions to and from the `int` type.  An attempt to add 1 to a `MyClass` object unexpectedly triggers an infinite loop due to the repeated implicit conversions during the addition operation.

## Reproduction

1. Clone this repository.
2. Compile and run the `Bug.cs` file.
3. Observe the `StackOverflowException`.

## Solution

The solution involves carefully considering the implications of implicit type conversions, particularly when combined with operations that might repeatedly trigger the conversions.   The corrected code (`BugSolution.cs`) provides an example of how to avoid this type of infinite recursion using explicit conversions and ensuring there are no circular dependencies among the conversions.