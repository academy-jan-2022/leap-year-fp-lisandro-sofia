module Tests
open LeapYearFunctional.LeapYear
open System
open Xunit

[<Theory>]
[<InlineData(4, 4, true)>]
[<InlineData(90, 9, true)>]
[<InlineData(10, 9, false)>]
let ``should return true when given number is divisible by divisor`` (number, divisor, expected) =
    let result =
        match number with
        | IsDivisibleBy divisor -> true
        |_ -> false
    
    Assert.Equal(expected, result)
    
[<Theory>]
[<InlineData(1997, false)>]
let ``should check if given year is a leap year`` (year, expected) =
    let result = check year
    
    Assert.Equal(expected, result)
    
