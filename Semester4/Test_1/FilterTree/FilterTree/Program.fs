type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | TerminalV of 'a

let filterTree tree func = 
    let rec recFilter tree func list = 
        match tree with
        | Tree(value, left, right) -> if (func value) then (value :: ((recFilter left func list) @ (recFilter right func list)))
                                      else ((recFilter left func list) @ (recFilter right func list));
        | TerminalV(value) -> if func value then (value :: list) else [];
    recFilter tree func []

let tree = Tree(5, Tree(4, TerminalV(3), Tree(6, TerminalV(7), TerminalV(8))), TerminalV(10))
let func = fun x -> x > 6

printfn "%A" <| filterTree tree func;