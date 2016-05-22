open System.Text.RegularExpressions
open System.Net
open System.IO

let getInfo(url: string) =
    let getHtml(url: string) =
        async { 
            let req = WebRequest.Create(url)
            use! response = req.AsyncGetResponse()
            use stream = response.GetResponseStream()
            use reader = new StreamReader(stream)
            return reader.ReadToEnd() }
    let func(url: string) =
        Async.RunSynchronously <|
            async {
                try
                    let! html = getHtml url
                    let regularExpression = new Regex(@"<a href=""http://.+?"">")
                    let matches = regularExpression.Matches(html)
                    let references = [|for i in matches -> i.Value.Substring(i.Value.IndexOf("=\"") + 2, i.Value.IndexOf("\">") - i.Value.IndexOf("=\"") - 2)|]
                    let tasks = [|for i in references -> getHtml i|]
                    let! info = Async.Parallel tasks 
                    for i in 0 .. references.Length - 1 do
                        printfn "%s --- %d" references.[i] info.[i].Length
                with
                    | exeption -> printfn "%s" exeption.Message }
    func url


getInfo "http://se.math.spbu.ru/SE/Members/ylitvinov/14-44/resultsSpring2016_244_Yurii"
//для других сайтов (например nba.com) нужно вообще какой-то хитрый парсинг придумывать, там каждая ссылка 
//как-то уникально представляется, просто так не обрежешь