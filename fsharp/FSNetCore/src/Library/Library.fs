(*
 * Copyright (c) 2019-2022 Markus Neifer
 * Licensed under the MIT License.
 * See file LICENSE in project root directory.
 *)
module Library

open Newtonsoft.Json

let getJsonNetJson value =
    sprintf "I used to be %s but now I'm %s thanks to JSON.NET!" value (JsonConvert.SerializeObject(value))
