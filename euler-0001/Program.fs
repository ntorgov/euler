// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    for n in 1 .. 1000 do
        let i = isValid(n);

    0 // return an integer exit code

// What's a fuck???
let isValid value =
    let Result = false;

    let isThree value = (value % 3) = 0;
    let isFive value = (value % 5) = 0;

    if isFive then Result=true else Result=false

    Result
