module Tests
open LeapYearFunctional.LeapYear
open Xunit

let boolAssertion value =
  if value then Assert.True else Assert.False

[<Theory>]
[<InlineData(4, 4, true)>]
[<InlineData(90, 9, true)>]
[<InlineData(10, 9, false)>]
let ``should return true when given number is divisible by divisor`` (number, divisor, expected) =
    match number with
      | IsDivisibleBy divisor -> true
      |_ -> false
    |> boolAssertion expected

[<Theory>]
[<InlineData(1997, false)>]
let ``should check if given year is a leap year`` (year, expected) =
    check year
    |> boolAssertion expected
