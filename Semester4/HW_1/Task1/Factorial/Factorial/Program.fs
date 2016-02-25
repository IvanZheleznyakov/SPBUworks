let rec factorial x =
    match x with
    | 0 | 1 -> 1
    | (_) -> x * factorial (x - 1)

let firstTemp = factorial 0
printfn "Factorial 0: %d" firstTemp

let secondTemp = factorial 9
printfn "Factorial 9: %d" secondTemp