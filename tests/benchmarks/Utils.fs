namespace FSharp.Core.Faster.Benchmarks

#nowarn "42"

module Utils =
    [<NoDynamicInvocation>]
    let inline retype<'T,'U> (x:'T) : 'U = (# "" x : 'U #)