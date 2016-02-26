let rec fibonacci x =
    match x with
    | 0 -> 0
    | 1 -> 1
    | (_) -> fibonacci (x - 1) + fibonacci (x - 2)

let firstTemp = fibonacci 4
let secondTemp = fibonacci 9
printfn "4th fibonacci is %d \n9th fibonacci is %d" firstTemp secondTemp