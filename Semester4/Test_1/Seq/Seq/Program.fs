let mySeq = 
    Seq.initInfinite (fun index ->
    let sign = if (index % 2 = 0) then 1 else -1
    ((index + 1) * sign) / (index + 1))

let funSeq seq = 
    Seq.mapi (fun index x -> (index + 1) * x) seq
printfn "seq is: %A" mySeq
printfn "modified seq is: %A" (funSeq mySeq)