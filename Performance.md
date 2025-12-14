# Advent of Code performance
Performance is measured using [BenchmarkDotNet](https://benchmarkdotnet.org/index.html). Mostly using default configuration and MemoryDiagnoser enabled.

## 2025

### Day 1
```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
AMD Ryzen 5 9600X 3.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean        | Error     | StdDev    | Gen0   | Allocated |
|---------- |------------:|----------:|----------:|-------:|----------:|
| Day1Part1 |    38.99 μs |  0.757 μs |  2.171 μs | 8.3008 | 136.29 KB |
| Day1Part2 | 1,407.90 μs | 24.964 μs | 22.130 μs | 7.8125 | 136.32 KB |

### Day 2
```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
AMD Ryzen 5 9600X 3.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean     | Error    | StdDev   | Gen0       | Allocated |
|---------- |---------:|---------:|---------:|-----------:|----------:|
| Day2Part1 | 21.58 ms | 0.342 ms | 0.380 ms | 11625.0000 | 185.94 MB |
| Day2Part2 | 47.62 ms | 0.396 ms | 0.309 ms | 21909.0909 | 350.25 MB |

### Day 3
```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
AMD Ryzen 5 9600X 3.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean      | Error    | StdDev   | Gen0    | Allocated |
|---------- |----------:|---------:|---------:|--------:|----------:|
| Day3Part1 | 116.01 μs | 1.730 μs | 1.618 μs | 41.5039 |  694432 B |
| Day3Part2 |  16.60 μs | 0.316 μs | 0.492 μs |       - |         - |
