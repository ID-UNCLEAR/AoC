# Advent of Code performance
Performance is measured using [BenchmarkDotNet](https://benchmarkdotnet.org/index.html). Mostly using default configuration and MemoryDiagnoser enabled.

## 2025

### Day 1

### Day 2
| Method    | Mean     | Error    | StdDev   | Gen0       | Allocated |
|---------- |---------:|---------:|---------:|-----------:|----------:|
| Day2Part1 | 22.88 ms | 0.264 ms | 0.220 ms | 11625.0000 | 185.94 MB |
| Day2Part2 | 49.99 ms | 0.927 ms | 1.496 ms | 21909.0909 | 350.25 MB |

### Day 3
| Method    | Mean     | Error    | StdDev   | Gen0    | Allocated |
|---------- |---------:|---------:|---------:|--------:|----------:|
| Day3Part1 | 133.4 μs | 2.58 μs  | 2.42 μs  | 41.5039 | 678.16 KB |
| Day3Part2 | 72.49 μs | 1.371 μs | 2.507 μs | 9.0332  | 148.47 KB |
