let rec isDifferent list =
    let firstInList num list =
        let rec find num list index =
          match list with
          | h :: t -> if h = num then Some(index) else find num t (index + 1)
          | [] -> None
        find num list 0
    match list with
    | h :: t -> match (firstInList h t) with
                | Some x -> false
                | None -> isDifferent t
    | [] -> true

let firstList = [0; 1; 2; 3; 4; 5; 6]
let secondList = [0; 1; 2; 3; 4; 2; 6]
printfn "all elements in %A are different: %b\nall elements in %A are different: %b" firstList (isDifferent firstList) secondList (isDifferent secondList)