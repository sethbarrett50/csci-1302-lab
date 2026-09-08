# Practice Recursion 01 — "Sum, Reverse, Fibonacci"

Write three recursive methods (no loops inside them):
- `Sum(int[] values)` — sum of all elements
- `Reverse(string text)` — the string reversed
- `Fibonacci(int n)` — the nth Fibonacci number, using the naive two-call recursive definition (`Fibonacci(n-1) + Fibonacci(n-2)`), not an optimized version

**Discussion:** run the program with `Fibonacci(32)` vs `Fibonacci(10)`. Why does it take so much longer for a number that's only 3x bigger? (Hint: count how many times `Fibonacci(2)` gets recomputed.)

## Self-check
- `Sum` and `Reverse` handle an empty array/string correctly (base case, not a crash)
- `Fibonacci(0)` and `Fibonacci(1)` return correctly without recursing further
- You can explain in your own words why naive recursive Fibonacci gets slow so fast
