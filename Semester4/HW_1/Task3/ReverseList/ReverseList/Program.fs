let reverseList ls = 
    let rec reverse firsts seconds =
        match firsts with
        | h :: t -> reverse t (h :: seconds)
        | [] -> seconds
    reverse ls []

let firstTemp = reverseList [ 1 ]
let secondTemp = reverseList [ 1; 2; 3; 4; 5; 6; 7 ]
printfn "[1; 2; 3] - reverse: %A" firstTemp
printfn "[1; 2; 3; 4; 5; 6; 7] - reverse: %A" secondTemp