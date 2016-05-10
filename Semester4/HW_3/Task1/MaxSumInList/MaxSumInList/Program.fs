let findMaxSum list =
    let rec findMaxSumRec list prev curIndex maxIndex curMax =
        match list with
        | h :: t -> if (h + prev > curMax) then findMaxSumRec t h (curIndex + 1) curIndex (h + prev)
                                           else findMaxSumRec t h (curIndex + 1) maxIndex curMax
        | [] -> maxIndex
    findMaxSumRec list 0 0 0 0

let list = [1; 5; 6; 2]
printfn "index of max sum in %A is %d" list (findMaxSum list)