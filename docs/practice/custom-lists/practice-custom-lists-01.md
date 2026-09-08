# Practice Custom Lists 01 — "SimpleLinkedList"

Build a generic `SimpleLinkedList<T>` (singly-linked, built from your own internal node type) supporting:
- `Add(T value)` — append to the end
- `RemoveFirst()` — remove the oldest-added item, returns whether anything was removed
- `Contains(T value)`
- `Count`
- enough to support `foreach` (implement `IEnumerable<T>`)

## Self-check
- Works correctly on an empty list — `RemoveFirst()`/`Contains()` don't throw, they just report "nothing there"
- `Count` stays accurate across a mix of `Add`/`RemoveFirst` calls
- `foreach` visits items in the order they were added
