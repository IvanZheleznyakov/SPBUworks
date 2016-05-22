open System
open System.Collections.Generic

exception AddInfoDuringWorking of string
exception WrongLinksAddedException of string

let random = new System.Random()

type OperatingSystem = { OSName: string; probabilityOfInfection: double }

type Computer = { operatingSystem: OperatingSystem; mutable isInfected: bool }

type LocalNetwork() =
    let mutable computers = new List<Computer>()
    let mutable linksBetweenComputers = new List<List<bool>>()
    let mutable infectedComputers = 0
    let mutable isWorking = false 

    member this.AddComputer(newComputer: Computer) =
        if isWorking then raise(AddInfoDuringWorking(""))
        computers.Add(newComputer)
        linksBetweenComputers.Add(new List<bool>())
        for i in 0 .. linksBetweenComputers.Count - 1 do
            if i = (linksBetweenComputers.Count - 2) then 
                for j in 0 .. (linksBetweenComputers.Count - 2) do
                    linksBetweenComputers.Item(j).Add(false)
            linksBetweenComputers.Item(linksBetweenComputers.Count - 1).Add(false)
        if newComputer.isInfected then infectedComputers <- (infectedComputers + 1)

    member this.AddLink(i: int, j: int) =
        if isWorking then raise(AddInfoDuringWorking(""))
        if (i > computers.Count - 1 || j > computers.Count - 1) then raise(WrongLinksAddedException(""))
        linksBetweenComputers.Item(i).Item(j) <- true
        linksBetweenComputers.Item(j).Item(i) <- true

    member this.Start() =
        this.ShowState()
        while infectedComputers <> computers.Count do this.Step()

    member this.Step() =
        isWorking <- true
        let mutable smthIsInfected = false
        let mutable willBeInfected = new List<int>()
        for i in 0 .. computers.Count - 1 do
            if not (computers.Item(i)).isInfected then
                for j in 0 .. computers.Count - 1 do
                    if (linksBetweenComputers.Item(i).Item(j) && computers.Item(j).isInfected && not smthIsInfected) then
                        if (random.NextDouble() <= computers.Item(i).operatingSystem.probabilityOfInfection) then
                            willBeInfected.Add(i)
                            smthIsInfected <- true
        for i in 0 .. willBeInfected.Count - 1 do
            computers.Item(willBeInfected.Item(i)).isInfected <- true
            infectedComputers <- infectedComputers + 1
        if infectedComputers = computers.Count then isWorking <- false
        this.ShowState()
        
    member this.ShowState() = 
        for i in 0 .. computers.Count - 1 do
            let mutable state = i.ToString() + " computer with " + computers.Item(i).operatingSystem.OSName + " is"
            if not (computers.Item(i)).isInfected then state <- state + " not"
            state <- state + " infected"
            printfn "%s" state
        printfn ""

let network = new LocalNetwork()
let linux = { OSName = "Linux"; probabilityOfInfection = 1.0 }
let windows = { OSName = "Windows"; probabilityOfInfection = 0.5 }
network.AddComputer({ operatingSystem = linux; isInfected = true });
network.AddComputer({ operatingSystem = windows; isInfected = false });
network.AddComputer({ operatingSystem = linux; isInfected = false });
network.AddComputer({ operatingSystem = windows; isInfected = false });
network.AddComputer({ operatingSystem = windows; isInfected = false });
network.AddComputer({ operatingSystem = linux; isInfected = true });
network.AddLink(0, 1);
network.AddLink(1, 2);
network.AddLink(2, 3);
network.AddLink(3, 4);
network.AddLink(4, 5);
network.Start();