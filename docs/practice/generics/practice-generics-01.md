# Practice Generics 01 — "Pair + Swap"

Build a generic class `Pair<TFirst, TSecond>` holding two values of independent types, with a `Describe()` method returning something like `"(1, Alex)"`. Also build a generic method `Swap<T>(ref T a, ref T b)` that swaps two values in place.

## Self-check
- `Pair<int, string>`, `Pair<string, string>`, etc. all work with the same class definition
- `Swap` works correctly for both value types (e.g. `int`) and reference types (e.g. `string`)
