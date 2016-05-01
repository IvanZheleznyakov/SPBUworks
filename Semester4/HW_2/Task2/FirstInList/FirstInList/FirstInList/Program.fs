let firstInList num list =
    let rec find num list index =
        match list with
        | h :: t -> if h = num then Some(index) else find num t (index + 1)
        | [] -> None
    find num list 0

match firstInList 2 [0; 1; 2; 3] with
| Some x -> printfn "%d" x
| None -> printfn "there is no dis num"

match firstInList 5 [0; 1; 2; 3] with
| Some x -> printfn "%d" x
| None -> printfn "there is no dis num"