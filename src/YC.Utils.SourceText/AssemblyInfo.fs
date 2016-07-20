namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("YC.Utils.SourceText")>]
[<assembly: AssemblyProductAttribute("YC.Utils.SourceText")>]
[<assembly: AssemblyDescriptionAttribute("Helpers for source code basic manipulation.")>]
[<assembly: AssemblyVersionAttribute("0.3.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.3.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.0.1"
    let [<Literal>] InformationalVersion = "0.3.0.1"
