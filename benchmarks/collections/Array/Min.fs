namespace FSharp.Faster.Benchmarks.Collections.Array.Min

open BenchmarkDotNet.Attributes
open FSharp.Faster.Benchmarks.Collections.Array.Utils

[<GenericTypeArguments(typeof<int>)>]
[<GenericTypeArguments(typeof<int64>)>]
[<GenericTypeArguments(typeof<double>)>]
[<BenchmarkCategory("Array", "Array.Min")>]
type ArrayMin<'T when 'T : comparison>() =
    inherit ArrayBenchmarkBase<'T>()

    [<Benchmark(Description="Array.min - FSharp.Core.Faster")>]
    member inline this.MinFaster() =
        FSharp.Core.Faster.Collections.Array.min this.Array

    [<Benchmark(Description="Array.min - FSharp.Core")>]
    member inline this.MinDefault() =
            Microsoft.FSharp.Collections.Array.min this.Array
