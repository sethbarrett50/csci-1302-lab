# Practice Random & Overflow 01 — "Dice + Overflow"

Build a `DiceSimulator` that wraps a `System.Random` constructed with a **seed**, with a `RollDie()` method returning 1-6. Seeding matters here: it's what makes the sequence reproducible enough to test.

Also write two small methods showing `int` overflow: `UncheckedAdd(int a, int b)` (wraps around silently) and `CheckedAdd(int a, int b)` (throws `OverflowException`) — try both with `int.MaxValue + 1`.

## Self-check
- Two `DiceSimulator`s constructed with the **same seed** produce the exact same sequence of rolls
- `RollDie()` never returns anything outside 1-6
- `UncheckedAdd(int.MaxValue, 1)` wraps around to `int.MinValue`
- `CheckedAdd(int.MaxValue, 1)` throws `OverflowException`
