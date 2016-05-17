type Expression =
    | Const of int
    | Var of char
    | Sum of Expression * Expression
    | Diff of Expression * Expression
    | Mult of Expression * Expression
    | Div of Expression * Expression

let rec differentiation (expression: Expression) =
    match expression with 
    | Const(_) -> Const(0);
    | Var(_) -> Const(1);
    | Sum(expr1, expr2) -> Sum(differentiation expr1, differentiation expr2);
    | Diff(expr1, expr2) -> Diff(differentiation expr1, differentiation expr2);
    | Mult(expr1, expr2) -> Sum(Mult(differentiation expr1, expr2), Mult(expr1, differentiation expr2));
    | Div(expr1, expr2) -> Div(Diff(Mult(differentiation expr1, expr2), Mult(expr1, differentiation expr2)), Mult(expr2, expr2));

let rec simplification (expression: Expression) =
    let IFOUNDIT action expr1 expr2 =
        let newExpr1 = simplification expr1;
        let newExpr2 = simplification expr2;
        match newExpr1, newExpr2 with
        | Const(0), expr -> expr;
        | expr, Const(0) -> expr;
        | Const(c1), Const(c2) -> simplification <| action (newExpr1, newExpr2);
        | expr1, expr2 -> action (expr1, expr2);
    match expression with
    | Const(c) -> Const(c);
    | Var(x) -> Var(x);
    | Sum(expr1, expr2) -> match expr1, expr2 with
                           | Const(c1), Const(c2) -> Const(c1 + c2);
                           | expr1, expr2 -> IFOUNDIT Sum expr1 expr2;
    | Diff(expr1, expr2) -> match expr1, expr2 with
                            | Const(c1), Const(c2) -> Const(c1 - c2);
                            | Var(x1), Var(x2) -> Const(0);
                            | _, _ -> IFOUNDIT Diff expr1 expr2;
    | Mult(expr1, expr2) -> match expr1, expr2 with
                            | Const(c1), Const(c2) -> Const(c1 * c2);
                            | Const(0), _ | _, Const(0) -> Const(0);
                            | _, _ -> if expr1 = Const(1) then simplification expr2
                                      else if expr2 = Const(1) then simplification expr1
                                      else IFOUNDIT Mult expr1 expr2;
    | Div(expr1, expr2) -> match expr1, expr2 with
                           | Const(c1), Const(c2) -> Const(c1 / c2);
                           | Var(x1), Var(x2) -> Const(1);
                           | _, _ -> if expr1 = Const(0) then Const(0)
                                     else if expr2 = Const(1) then simplification expr1 
                                     else IFOUNDIT Div expr1 expr2;


let test = Sum(Diff(Mult(Const 8, Var 'x'), Mult(Const 3, Var 'x')), Div(Var 'x', Var 'x'));
//(8x - 3x) + (x / 1)
let difTest = differentiation test;
let simpTest = simplification difTest;

printfn "%A" simpTest;