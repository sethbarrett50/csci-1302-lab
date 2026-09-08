# Practice Trees 01 — "Binary Search Tree"

Build a `BinarySearchTree` of `int` supporting:
- `Insert(int value)`
- `Contains(int value)`
- `InOrderTraversal()` — returns values in sorted order

**Stretch (optional):** once the plain BST works, look at `lectures/data/AVLtrees.md` and try adding rebalancing so the tree stays roughly balanced after inserts. Not required — the core lab is just the plain BST.

## Self-check
- `InOrderTraversal()` returns a sorted sequence no matter what order you inserted values in
- `Contains()` correctly returns `false` for values that were never inserted
- Works correctly on an empty tree
