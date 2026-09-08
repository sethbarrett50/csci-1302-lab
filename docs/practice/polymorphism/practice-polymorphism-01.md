# Practice Polymorphism 01 — "Payroll"

Build a base class `Employee` with a `virtual CalculatePay()` returning `decimal`. Add derived classes `HourlyEmployee`, `SalariedEmployee`, and `CommissionEmployee`, each `override`-ing `CalculatePay()` with their own formula. Mark `SalariedEmployee` `sealed` (no further subclasses planned — this is the first lab where `sealed` actually belongs, now that polymorphism itself has been covered).

Build a `List<Employee>` mixing all three kinds and sum total payroll by calling `CalculatePay()` through the base `Employee` reference.

## Self-check
- Iterating the `List<Employee>` and calling `CalculatePay()` dispatches to each object's *actual* (derived) implementation at runtime, not the base one
- Total payroll is the sum of each employee's correct, type-specific pay
