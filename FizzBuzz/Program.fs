// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom


let getUserKeyInput() =
        printfn "Please enter a positive integer"
        let limit = System.Console.ReadLine()
        limit

let printFizzBuzz(limit) =
    printfn"input number is : %s" limit
   

    [1..limit |> int] |> Seq.map (function
    | num when num%3=0 -> "Fizz"
    | num when num%5=0 -> "Buzz"
    | num when num%5=0 && num%3=0 -> "FizzBuzz"
    | num -> string num)
    |> Seq.iter (printfn "%s")
    0


[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    let limit = getUserKeyInput()
    printFizzBuzz limit |> ignore
    0 // return an integer exit code



