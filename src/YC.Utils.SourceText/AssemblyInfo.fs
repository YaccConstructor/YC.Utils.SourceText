namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("YC.Utils.SourceText")>]
[<assembly: AssemblyProductAttribute("YC.Utils.SourceText")>]
[<assembly: AssemblyDescriptionAttribute("Helpers for source code basic manipulation.")>]
[<assembly: AssemblyVersionAttribute("0.3.0.0")>]
[<assembly: AssemblyFileVersionAttribute("0.3.0.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.0.0"
    let [<Literal>] InformationalVersion = "0.3.0.0"
