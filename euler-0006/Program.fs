// Learn more about F# at http://fsharp.org

open System

let Numbers = [ 1..100 ]

[<EntryPoint>]
let main argv =

    let mutable squaresSum = 0
    let mutable numbersSum = 0

    for value in Numbers do
        squaresSum <- squaresSum + (value * value)
        numbersSum <- numbersSum + value

    let result = numbersSum * numbersSum

    let final = result - squaresSum;

    Console.WriteLine("Result is " + final.ToString())
    Console.ReadLine()

    0 // return an integer exit code
