# Practice Props/Exceptions 01 — “Bank Account”

Create a `BankAccount` class with:
- `Owner` (string)
- `Balance` (decimal) — cannot go below 0
- `Deposit(decimal amount)` — amount must be > 0
- `Withdraw(decimal amount)` — must be > 0 and not exceed Balance

Use exceptions for invalid operations.

## Self-check
- Attempting invalid deposit/withdraw throws an exception
- Balance never becomes negative