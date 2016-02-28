let powersOfTwo n =
    let rec power ls n i =
        if i = 0.0 then ls else power ((2.0 ** (n - i + 5.0)) :: ls) n (i - 1.0)
    let reverseList ls = 
        let rec reverse firsts seconds =
            match firsts with
            | h :: t -> reverse t (h :: seconds)
            | [] -> seconds
        reverse ls []

    reverseList <| power [] n 5.0


let list = powersOfTwo 3.0
printfn "%A" list