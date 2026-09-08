# Practice Static Members 01 — "Unit Converter"

Build a static `UnitConverter` class with:
- static methods: `CelsiusToFahrenheit`, `FahrenheitToCelsius`, `MilesToKilometers`, `InchesToCentimeters`
- a static counter tracking how many conversions have been performed in total, across all methods

## Self-check
- Works without ever creating an instance of `UnitConverter`
- The counter keeps increasing across unrelated calls — it's shared state, not per-call
