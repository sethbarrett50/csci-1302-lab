# Practice References 01 — "Value vs. Reference"

Write two methods:
- `TryIncrementValue(int value)` — increments the parameter. Since `int` is a value type, this should have **no effect** on the caller's variable.
- `IncrementCounter(Counter counter)` — increments `counter.Value`. Since `Counter` is a class (reference type), the caller's object **should** reflect the change, because both caller and callee point at the same object.

Also write `TryParseCoordinate(string text, out int x, out int y)` that parses a `"x, y"` string into two `out int` parameters, returning whether parsing succeeded.

## Self-check
- After calling `TryIncrementValue`, the caller's own `int` is unchanged
- After calling `IncrementCounter`, the caller's `Counter.Value` **is** changed
- `TryParseCoordinate` correctly reports failure (and still assigns `out` params, even if to 0) on malformed input
