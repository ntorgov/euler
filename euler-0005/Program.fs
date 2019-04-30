// Learn more about F# at http://fsharp.org

open System
open System

// Список делителей
let Dividers = [ 1..20 ]

// Вычисление, является ли одно число дилителем для другого
let IsDevide a b =
    a % b = 0

// Проверка списка делителей
let IsProper(value : int) : bool =
    let mutable Result = true

    for divider in Dividers do
        if Result = true then
            Result <- IsDevide value divider = true

    Result;


[<EntryPoint>]
let main argv =
    let mutable result = false
    let mutable value = 1;
    let mutable counter = 1;
    while (result <> true) do
        result <- IsProper value
        if counter >= 100000 then
            Console.WriteLine("Try " + value.ToString() + ", result " + result.ToString())
            counter <- 0
        value <- value + 1
        counter <- counter + 1

    Console.WriteLine("Result is " + (value-1).ToString())
    let n = Console.ReadLine()
    0 // return an integer exit code
