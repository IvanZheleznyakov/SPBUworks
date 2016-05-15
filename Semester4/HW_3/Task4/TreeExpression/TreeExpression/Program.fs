type Expression =
    | Number of int
    | Sum of Expression * Expression
    | Diff of Expression * Expression
    | Mult of Expression * Expression
    | Div of Expression * Expression

let rec countExpression expression =
    match expression with
        | Number(value) -> value
        | Sum(first, second) -> countExpression first + countExpression second
        | Diff(first, second) -> countExpression first - countExpression second
        | Mult(first, second) -> countExpression first * countExpression second
        | Div(first, second) -> countExpression first / countExpression second

let test = Sum(Mult(Number 3, Number 9), Diff(Number 40, Div(Number 60, Number 2)))
let result = countExpression test

printfn "(3 * 9) + (40 - (60 / 2)) = %i" result