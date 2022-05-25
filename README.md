# Benchmark

A simple example of using Benchmark.NET.

## Execute

1. Open you command line
2. cd <yourprojectpath>/bin/release/net5.0
3. dotnet Benchmark.dll

## Intro

When we work we performance, it isn't easy and it requires a lot of patience and a good knowledge of current performance.

Using benchmark before an optimization process is very useful because we can understand our position.
In this way we can check if our changes have a good impact or not.

## What is

It's a measurement or set of it relating to the execution of a part of code or its little part. 

Naturally, it isn't mandatory the use of a benchmark, sometimes we need a simple stopwatch (but we must know factors that can reduce the precision).
  
## Analysis

Once done you will get a results table.
For each benchmarked method you’ll have a row with the result data.

Mean, it's the time mean of execution.

Other statistical data is available for the error and standard deviation of the timing data across the iterations.
  
![Benchmark](https://pbs.twimg.com/media/FNa8blVXMAUP4II?format=jpg&name=small)
