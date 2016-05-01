let isPalindrom str = 
    let list (str: string) = List.ofArray (str.ToCharArray())
    let reverseList ls = 
        let rec reverse firsts seconds =
            match firsts with
            | h :: t -> reverse t (h :: seconds)
            | [] -> seconds
        reverse ls []
    list str = reverseList (list str)

printfn "%s is palindrome: %b\n%s is palindrome: %b" "ololo" (isPalindrom "ololo") "ololol" (isPalindrom "ololol")