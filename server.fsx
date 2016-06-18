#r "./packages/Suave/lib/net40/Suave.dll"
open System
open System.Net
open Suave
open Suave.Http
open Suave.Web

let config =
  { defaultConfig with
       bindings = [HttpBinding.mk HTTP (IPAddress.Parse "0.0.0.0") 8083us]
  }

startWebServer config (Successful.OK "Hello F# World!")
