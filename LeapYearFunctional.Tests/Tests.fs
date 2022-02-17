module Tests
open LeapYearFunctional.LeapYear
open System
open Xunit

[<Theory>]
[<InlineData(4, 4, true)>]
let ``should return true when given number is divisible by divisor`` (number, divisor, expected) =
    let result =
        match number with
        | IsDivisibleBy divisor -> true
        |_ -> false
    
    Assert.Equal(expected, result)