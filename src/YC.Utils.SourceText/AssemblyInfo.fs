namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("YC.Utils.SourceText")>]
[<assembly: AssemblyProductAttribute("YC.Utils.SourceText")>]
[<assembly: AssemblyDescriptionAttribute("Helpers for source code basic manipulation.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
    let [<Literal>] InformationalVersion = "1.0"
