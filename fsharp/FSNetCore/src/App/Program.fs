(*
 * Copyright (c) 2019-2022 Markus Neifer
 * Licensed under the MIT License.
 * See file LICENSE in project root directory.
 *)
open System
open Library

[<EntryPoint>]
let main argv =
    printfn "Nice command-line arguments! Here's what JSON.NET has to say about them:"

    argv
    |> Array.map getJsonNetJson
    |> Array.iter (printfn "%s")

    0 // return an integer exit code
