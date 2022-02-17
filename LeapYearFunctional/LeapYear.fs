namespace LeapYearFunctional
module  LeapYear =

let (|IsDivisibleBy|_|) divisor number =
    match number % divisor with
    | 0 -> Some ()
    | _ -> None
    
let check year =
    match year with
    | IsDivisibleBy 4 -> true
    |_ -> false
    
    