type RecordInBook =
    { 
    Name: string;
    PhoneNumber: int;
    }

let path = 
    "book.txt";

let addRecord book (newRecord: RecordInBook) = 
    let newBook = newRecord :: book;
    newBook;

let rec findNumber book name =
    match book with
    | h :: t -> if h.Name = name then Some(h.PhoneNumber) else findNumber t name
    | [] -> None

let rec findName book number =
    match book with
    | h :: t -> if h.PhoneNumber = number then Some(h.Name) else findName t number
    | [] -> None

let recordsToString book = 
    let rec loop book stringBook =
        match book with
        | h :: t -> loop t ((h.Name + " " + h.PhoneNumber.ToString()) :: stringBook)
        | [] -> stringBook
    loop book []

let savePhoneBookInFile book =
    System.IO.File.WriteAllLines(path, recordsToString book);

let stringToRecords (str: List<string>) = 
    let rec loop book (str: List<string>) = 
        match str with
        | h :: t -> let temp = h.Split(' ')
                    loop ({Name = temp.[0]; PhoneNumber = int (temp.[1])} :: book) t
        | [] -> book
    loop [] str

let readFromFile =
    if System.IO.File.Exists path then
        let str = List.ofArray (System.IO.File.ReadAllLines(path))
        Some(stringToRecords str)
    else
        None;

let inputDialog =
    let rec loop book =
        printfn "Input number of command you want to do:";
        printfn "0 - exit";
        printfn "1 - add record to book";
        printfn "2 - find number by name";
        printfn "3 - find name by number";
        printfn "4 - save book in file";
        printfn "5 - read data to book from file";
        let command = System.Console.ReadLine();
        match command with
        | "0" -> ()
        | "1" -> printfn "Input name:";
                 let name = System.Console.ReadLine();
                 printfn "Input number:";
                 let number = System.Console.ReadLine();
                 loop <| addRecord book { Name = name; PhoneNumber = int (number); }
        | "2" -> printfn "Input name:";
                 let name = System.Console.ReadLine();
                 match findNumber book name with
                 | Some(a) -> printfn "%d" a;
                 | None -> printfn "This record doesnt exist";
                 loop book;
        | "3" -> printfn "Input number:";
                 let number = System.Console.ReadLine();
                 match findName book (int (number)) with
                 | Some(a) -> printfn "%s" a;
                 | None -> printfn "This record doesnt exist";
                 loop book;
        | "4" -> savePhoneBookInFile book;
                 printfn "Book is saved in file";
                 loop book;
        | "5" -> match readFromFile with
                 | Some(a) -> printfn "Data were read";
                              loop a;
                 | None -> printfn "File doesnt exist";
                           loop book;
        | _ -> printfn "Wrong command";
               loop book;
    loop [];

inputDialog;