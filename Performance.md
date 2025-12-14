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
| Method    | Mean         | Error     | StdDev    | Allocated |
|---------- |-------------:|----------:|----------:|----------:|
| Day1Part1 |     9.319 us | 0.0633 us | 0.0528 us |         - |
| Day1Part2 | 1,373.854 us | 9.5259 us | 8.4445 us |         - |

### Day 2
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
| Day2Part1 | 10.83 ms | 0.056 ms | 0.053 ms |         - |
| Day2Part2 | 16.78 ms | 0.134 ms | 0.126 ms |         - |

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
