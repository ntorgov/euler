// Learn more about F# at http://fsharp.org

open System
open System.IO

let readLines (filePath:string) = seq {
    Console.WriteLine(filePath)
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

[<EntryPoint>]
let main argv =
    let filePath = "../../../p022_names.txt";

    let result = readLines(filePath)

    printfn "Hello World from F#!"
    Console.ReadLine();
    0 // return an integer exit code

