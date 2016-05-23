open System.ComponentModel

let sumIt = 
    let array = Array.create 1000000 1
    let result = ref 0
    let flags = Array.create 100 false

    let sum index =
        let rec loop i acc =
            if i > index + 9999 then acc
            else loop (i + 1) (acc + array.[i])
        loop index 0

    let loop = 
        for i in 0..99 do
            let worker = new BackgroundWorker()
            worker.DoWork.Add(fun args -> args.Result <- box <| sum (10000 * i)) 
            worker.RunWorkerCompleted.Add(fun args -> 
                                            result := !result + (args.Result :?> int)
                                            flags.[i] <- true)
            worker.RunWorkerAsync()

    loop

    while not (Array.forall(fun x -> x = true) flags) do ()

    !result

printfn "%A" sumIt