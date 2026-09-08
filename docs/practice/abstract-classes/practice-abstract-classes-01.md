# Practice Abstract Classes 01 — "Notification System"

Build an abstract class `Notification` with:
- a `Recipient` property (set via a `protected` constructor)
- an `abstract void Send()` method
- a concrete, shared `LogSent(string channel)` helper method

Add derived classes `EmailNotification`, `SmsNotification`, `PushNotification`, each implementing `Send()` with its own message format, and calling the shared `LogSent()` at the end.

## Self-check
- `Notification` cannot be instantiated directly — the compiler rejects `new Notification(...)`
- Each derived class supplies its own `Send()` behavior while reusing the same `LogSent()` logic, rather than duplicating it
