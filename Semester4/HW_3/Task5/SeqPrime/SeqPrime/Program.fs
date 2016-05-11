let isPrime n =
    let rec check i =
        i > n / 2 || (n % i <> 0 && check (i + 1))
    check 2

let mySeq = Seq.initInfinite (fun index -> index + 2) |> Seq.filter(fun x -> isPrime x)
printfn "inf seq of prime nums: %A" mySeq