open System
open System.Collections.Generic

exception ExtractFromEmpty of string

type Queue<'a>() = 
   let list = new List<'a*int>()
   
   member this.insert value key = 
      list.Add((value, key))

   member this.extract() =
      if (this.IsEmpty()) then
         raise(ExtractFromEmpty("Queue is empty"))
      let mutable curMinKey = snd (list.Item(0))
      let mutable curInd = 0;
      let sizeOfList = list.Count - 1
      for i in 0 .. sizeOfList do 
        if (snd (list.Item(i)) < curMinKey) then 
            curMinKey <- snd (list.Item(i))
            curInd <- i

      let value = fst (list.Item(curInd))     
      list.RemoveAt (curInd)
      value

   member this.IsEmpty() =
      list.Count = 0

let queue = new Queue<int>()
queue.insert 0 5
queue.insert 2 3
queue.insert 1 7

try 
    printfn "%d" (queue.extract())
    printfn "%d" (queue.extract())
    printfn "%d" (queue.extract())  
    printfn "%d" (queue.extract())

with
    | ExtractFromEmpty(message) -> printfn "%A" message