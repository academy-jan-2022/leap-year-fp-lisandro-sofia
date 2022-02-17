namespace LeapYearFunctional
module  LeapYear =

let (|IsDivisibleBy|_|) number divisor =
    match number % divisor with
    | 0 -> Some ()
    | _ -> None
    
    