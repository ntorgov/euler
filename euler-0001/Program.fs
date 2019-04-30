open System

// What's a fuck???
let isValid value =
    //let Result = false;

    let is_Three = (value % 3) = 0;
    let is_Five = (value % 5) = 0;

    let mutable Result = (is_Three || is_Five)

    Result

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let mutable FinalResult = 0

    for n = 1 to 999 do
        let i = isValid n
        if i then FinalResult <- FinalResult + n

    printfn "Result is %d" FinalResult

    0 // return an integer exit code
