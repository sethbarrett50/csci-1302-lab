# Practice Exceptions 01 — "Safe Calculator"

Build a `SafeCalculator.Calculate(int left, int right, string operatorSymbol)` that supports `+`, `-`, `*`, `/`. Define a custom `InvalidOperatorException` for unrecognized operator symbols. Division by zero should surface the built-in `DivideByZeroException` naturally (don't swallow it inside `Calculate`).

Around each call, use `try`/`catch`/`finally`: catch `DivideByZeroException` and `InvalidOperatorException` in their own specific `catch` blocks (not one blanket `catch (Exception)`), and use `finally` to log that the attempt happened, regardless of outcome.

## Self-check
- Divide-by-zero and invalid-operator cases are each caught by their own specific `catch` block
- `finally` runs every time — on the success path and on both failure paths
- A valid calculation (e.g. `10 / 2`) still returns the correct result
