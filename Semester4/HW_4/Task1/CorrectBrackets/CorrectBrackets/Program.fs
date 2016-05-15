let isCorrect (str: string) = 
    let list = List.ofArray (str.ToCharArray())
    let isRightClosingBracket bracket ls = 
        match ls with
        | h :: t -> (h = bracket)
        | [] -> false
    let deleteFirst ls =
        match ls with
        | h :: t -> t
        | [] -> []
    let rec isCorrectRec ls openBrackets = 
        match ls with
        | h :: t -> match h with
                    | x when x = '(' || x = '[' || x = '{' -> isCorrectRec t (h :: openBrackets)
                    | ')' -> if isRightClosingBracket '(' openBrackets then isCorrectRec t (deleteFirst openBrackets) else false
                    | ']' -> if isRightClosingBracket '[' openBrackets then isCorrectRec t (deleteFirst openBrackets) else false
                    | '}' -> if isRightClosingBracket '{' openBrackets then isCorrectRec t (deleteFirst openBrackets) else false
                    | _ -> isCorrectRec t openBrackets
        | [] -> List.isEmpty openBrackets
    isCorrectRec list []

let firstTest = "( ahah [ smeshno ( mdaaa ) ne o4en' ) heh ]"
let secondTest = "{zdes'(  vse) dolzhno bit' }[(V)E[R]N]O"
let thirdTest = "(()){"
printfn "%s: %b\n%s: %b\n%s: %b" <| firstTest <| isCorrect firstTest <| secondTest <| isCorrect secondTest <| thirdTest <| isCorrect thirdTest