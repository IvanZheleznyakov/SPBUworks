open System.Text.RegularExpressions
open System.Net
open System.IO

let getInfo(url: string) = 
    let getHtml(url : string) =
        async { 
            let req = WebRequest.Create(url)
            use! response = req.AsyncGetResponse()
            use stream = response.GetResponseStream()
            use reader = new StreamReader(stream)
            return reader.ReadToEnd() }
    let func(url: string) = 
        Async.RunSynchronously <|
            async {
                let! html = getHtml url
                let regularExpression = new Regex(@"<a href=""http://.+?"">")
                let matches = regex.Matches(html)
                let references = [|for i in matches -> i.Value.Substring(9, m.Value.Length - 11)|]
                let tasks = [|for i in references -> getHtml i|]
                let! info = Async.Parallel tasks 
                for i in 0 .. references.Length - 1 do
                    printfn "%s --- %d" references.[i] info.[i].Length }
    func url


getInfo "http://nba.com"