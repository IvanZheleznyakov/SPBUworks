let evenNumsMap list = 
    List.sum (list |> List.map (fun x -> (x + 1) % 2)) 

let evenNumsFilter list =
    List.length (list |> List.filter (fun x -> x % 2 = 0))

let evenNumsFold list = 
    List.fold (fun acc x -> (acc + ((x + 1) % 2))) 0 list
    

let list = [1; 6; 2; 3; 4; 5; 4]
printfn "even nums in %A with map: %d" list (evenNumsMap list)
printfn "even nums in %A with filter: %d" list (evenNumsFilter list)
printfn "even nums in %A with fold: %d" list (evenNumsFold list)