# Practice Stacks & Queues 01 — "Balanced Parentheses + Print Queue"

Two small problems:

1. **Balanced Parentheses** (`Stack<char>`): given a string containing `()`, `[]`, `{}`, determine whether every opening bracket has a matching, correctly-nested closing bracket.
2. **Print Queue Simulator** (`Queue<string>`): enqueue job names and process them one at a time, always in the order they arrived.

## Self-check
- Balanced-parens check correctly handles nesting (`([]{})`) and mismatched pairs (`([)]`, `(]`)
- An empty string or a lone closing bracket is correctly reported as unbalanced
- The print queue always processes jobs in the exact order they were enqueued (FIFO), never LIFO
