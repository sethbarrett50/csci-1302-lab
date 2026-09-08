# Practice Inheritance 01 — "Shape Hierarchy"

Build a base class `Shape` with a `Name` property (set via constructor) and a `Describe()` method that prints it. Add derived classes `Circle`, `Rectangle`, `Triangle`, each with their own fields and an `Area()` method.

This lab is about inheritance mechanics, not dynamic dispatch — `Area()` doesn't need to be `virtual`/`override` here (that's a later topic).

## Self-check
- Each derived class chains to the base constructor (`base(...)`) to set `Name`
- `Describe()` is written once on `Shape` and reused by every derived class without being duplicated
