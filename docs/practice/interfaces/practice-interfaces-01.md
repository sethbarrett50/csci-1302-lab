# Practice Interfaces 01 — "Media Library"

Define an `IPlayable` interface with `Play()` and `Stop()`. Implement it on three otherwise-unrelated classes — `Song`, `Podcast`, `AudioBook` — that do **not** share a common base class. Build a `List<IPlayable>` mixing all three and call `Play()`/`Stop()` on each through the interface reference.

## Self-check
- `Song`, `Podcast`, and `AudioBook` implement `IPlayable` without inheriting from a shared base class
- Calling `Play()`/`Stop()` through the `IPlayable` reference dispatches to each class's own implementation
