(*
 * Copyright (c) 2018 M. 'howlingmad' Neifer
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *)

// First, a list...
let list = ["foo"; "bar"; "baz"]

for item in list do
    printfn "Item:    %A" item

printfn "[0]:     %A" (list.[0])
printfn "Item(1): %A" (list.Item(1))

// ...then, an array.
let array = [|"foo"; "bar"; "baz"|]

for item in array do
    printfn "Item:    %A" item

printfn "[0]:     %A" (array.[0])
//printfn "Item(1): %A" (array.Item(1)) The field, constructor or member 'Item' is not defined

