module FSharp.ProjectScaffold.Tests

open FSharp.ProjectTemplate
open Expecto

[<Tests>]
let tests =
    testList "Library tests" [
        testCase "hello returns 42" <| fun _ ->
            let result = Library.hello 42
            Expect.equal result 42 "Result should have been 42"
        testProperty "In fact, hello returns 42 no matter what you pass it" <| fun x ->
            let result = Library.hello x
            Expect.equal result 42 "Result should always be 42 no matter what the parameter is"
    ]

[<EntryPoint>]
let main args =
    runTestsInAssembly defaultConfig args
