open System
open System.Collections
open System.Collections.Generic

type Tree<'a> = 
    | Tree of 'a * Tree<'a> * Tree<'a>
    | TerminalV of ('a option)

type Enumerator<'a when 'a : comparison>(tree : Tree<'a>) =
    let rec treeToList tree =
       match tree with
        | Tree(element, left, right) ->  element :: treeToList left @ treeToList right
        | TerminalV(element) -> match element with
                                | Some(x) -> [x]
                                | None -> [] 
   
    let list = ref (treeToList tree) 

    interface IEnumerator with
       member v.get_Current() =
        let current = (!list).Head :> obj 
        list := (!list).Tail
        current

        member v.MoveNext() = 
         match !list with
         | [] ->
            false
         | _ -> 
            true
        member v.Reset() = list := (treeToList tree)

    interface IEnumerator<'a> with
       member v.get_Current() = (!list).Head
       member v.Dispose () = ()

type BinaryTree<'a when 'a: comparison>() = 
    let mutable tree = TerminalV(None)

    member this.AddElement(value: 'a) = 
        let rec add tree value = 
            match tree with
            | Tree(element, left, right) -> if value < element then Tree(element, add left value, right)
                                            else Tree(element, left, add right value)
            | TerminalV(Some(element)) -> if value < element then Tree(element, TerminalV(Some(value)), TerminalV(None))
                                          else Tree(element, TerminalV(None), TerminalV(Some(value)))
            | TerminalV(None) -> TerminalV(Some(value))
        tree <- add tree value

    member this.RemoveElement(value: 'a) = 
        let rec rightMost tree =
            match tree with
            | TerminalV(None) -> TerminalV(None) 
            | TerminalV(a) -> TerminalV(a)
            | Tree(a, left, right) ->
                match right with
                | TerminalV(None) -> tree
                | _ -> rightMost right
        let rec recRemove tree x = 
            match tree with
            | TerminalV(None) -> TerminalV(None)
            | TerminalV(Some(a)) -> 
               if a = x then TerminalV(None)
               else tree
            | Tree(a, left, right) ->
                if x > a then Tree(a, left, recRemove right x)
                elif x < a then Tree(a, recRemove left x, right)
                else
                   match right with
                   | TerminalV(None) -> TerminalV(None)        
                   | _ ->
                     match left with
                     | TerminalV(None) -> right 
                     | _ ->
                        let forRemove = rightMost left
                        match forRemove with
                        | TerminalV(Some(a)) -> Tree(a, recRemove left a, right)
                        | _ -> TerminalV(None)
        tree <- recRemove tree value

    member this.IsInTree(value: 'a) = 
        let rec isInTree tree value = 
            match tree with
            | Tree(element, left, right) -> if value < element then isInTree left value
                                            elif value > element then isInTree right value
                                            else true
            | TerminalV(element) -> match element with
                                    | Some(x) -> if value = x then true else false
                                    | None -> false
        isInTree tree value

    interface IEnumerable with
       member t.GetEnumerator() = new Enumerator<'a>(tree) :> IEnumerator

let tree = new BinaryTree<int>()
tree.AddElement(1)
tree.AddElement(5)
tree.AddElement(3)
tree.AddElement(2)
tree.AddElement(4)
tree.RemoveElement(2)
tree.AddElement(2)
tree.AddElement(6)
tree.AddElement(-10)
tree.RemoveElement(2)
tree.RemoveElement(1)
for i in tree do
    printfn "%A" i