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
| Method    | Mean     | Error    | StdDev   | Gen0       | Allocated   |
|---------- |---------:|---------:|---------:|-----------:|------------:|
| Day2Part1 | 10.60 ms | 0.029 ms | 0.026 ms |          - |           - |
| Day2Part2 | 49.29 ms | 0.528 ms | 0.494 ms | 21909.0909 | 367268112 B |

### Day 3
```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
AMD Ryzen 5 9600X 3.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4

Job=.NET 10.0  Runtime=.NET 10.0  

```
| Method    | Mean     | Error    | StdDev   | Allocated |
|---------- |---------:|---------:|---------:|----------:|
| Day3Part1 | 65.16 us | 1.251 us | 1.537 us |         - |
| Day3Part2 | 16.33 us | 0.322 us | 0.371 us |         - |
