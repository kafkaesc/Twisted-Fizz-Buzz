# TwistedFizzBuzz Library and Console Apps

Built by Jared Hettinger

## TwistedFizzBuzz

TwistedFizzBuzz is a C# library for calculating and outputting FizzBuzz. It accepts an individual int, two ints representing a range, an array of ints that will be FizzBuzz'd from the beginning to the end of the array. The default FizzBuzz behavior of the library is to display "Fizz" every multiple of 3 and "Buzz" every multiple of 5. The words and divisors can be update by calling the SetFizzBuzz method. The behavior can be returned to default FizzBuzz by calling ResetFizzBuzz.

## StandardFizzBuzz

StandardFizzBuzz is a C# console app that will print the standard FizzBuzz solution [1-100] to the console.

## ExtraFizzBuzz

ExtraFizzBuzz is a C# console app that will demonstrate the extra featues of the TwistedFizzBuzz library. Instead of the normal Fizz on multiples of 3 and Buzz on multiples of 5, ExtraFizzBuzz will print Fizz on multiples of 5, Buzz on multiples of 9, and Bar on multiples of 27. It will run for the range of -27 to 120.

## TwistedFizzBuzzTest

TwistedFizzBuzzTest is a test project for with unit tests for the methods in TwistedFizzBuzz.
