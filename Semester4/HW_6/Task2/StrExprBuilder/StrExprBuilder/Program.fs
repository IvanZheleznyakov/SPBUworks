type StrExpr() =
    let parse str = 
        match System.Double.TryParse(str) with
        | true, value -> Some(value)
        | false, _ -> None

    member this.Bind(m, f) = 
        Option.bind f (parse m)

    member this.Return(x) = 
        Some(x)

let strexpr = new StrExpr()
    
let test1 = strexpr {
        let! x = "1"
        let! y = "2"
        let z = x + y
        return z
    }

let test2 = strexpr {
        let! x = "1"
        let! y = "Ъ"
        let z = x + y
        return z
    }

printfn "%A, %A, %A" test1 test2