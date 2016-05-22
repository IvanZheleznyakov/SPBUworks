type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | TerminalV of 'a

let rec mapTree tree func = 
    match tree with
    | Tree(value, left, right) -> Tree(func value, mapTree left func, mapTree right func)
    | TerminalV(value) -> TerminalV(func value)