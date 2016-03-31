type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | TerminalV of 'a

let rec heightOfTree tree =
    match tree with
    | Tree(_, l, r) -> 1 + max (heightOfTree l) (heightOfTree r)
    | TerminalV(_) -> 1