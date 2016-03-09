let multDigit x = 
    let rec inMultDigit y mult =
        match y with
        | 0 -> mult
        | _ -> inMultDigit (y / 10) (mult * (y % 10))
    match x with
    | 0 -> 0
    | _ -> inMultDigit x 1

printfn "%d, %d" <| multDigit 13212511 <| multDigit 0