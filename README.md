# CS 1302 Labs (C#/.NET)

| Practice Lab | Doc prompt | C# project | Key C# files |
|---|---|---|---|
| **Lab 01 — UML** | [`docs/practice/uml/practice-uml-01.md`](docs/practice/uml/practice-uml-01.md)<br>[`docs/practice/uml/practice-uml-02.md`](docs/practice/uml/practice-uml-02.md) | [`src/labs/01-uml/CS1302.Lab01.Uml/`](src/labs/01-uml/CS1302.Lab01.Uml/) | [`Program.cs`](src/labs/01-uml/CS1302.Lab01.Uml/Program.cs)<br>[`Models/Book.cs`](src/labs/01-uml/CS1302.Lab01.Uml/Models/Book.cs)<br>[`Models/Library.cs`](src/labs/01-uml/CS1302.Lab01.Uml/Models/Library.cs) |
| **Lab 02 — Arrays (1D)** | [`docs/practice/arrays-1d/practice-arrays1d-01.md`](docs/practice/arrays-1d/practice-arrays1d-01.md)<br>[`docs/practice/arrays-1d/practice-arrays1d-02.md`](docs/practice/arrays-1d/practice-arrays1d-02.md) | [`src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/`](src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/) | [`Program.cs`](src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/Program.cs)<br>[`Exercises/ArrayStats.cs`](src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/Exercises/ArrayStats.cs)<br>[`Exercises/ArraySearch.cs`](src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/Exercises/ArraySearch.cs) |
| **Lab 03 — Arrays (2D)** | [`docs/practice/arrays-2d/practice-arrays2d-01.md`](docs/practice/arrays-2d/practice-arrays2d-01.md) | [`src/labs/03-arrays-2d/CS1302.Lab03.Arrays2D/`](src/labs/03-arrays-2d/CS1302.Lab03.Arrays2D/) | [`Program.cs`](src/labs/03-arrays-2d/CS1302.Lab03.Arrays2D/Program.cs)<br>[`Exercises/GridMath.cs`](src/labs/03-arrays-2d/CS1302.Lab03.Arrays2D/Exercises/GridMath.cs) |
| **Lab 04 — Properties & Exceptions** | [`docs/practice/properties-exceptions/practice-props-ex-01.md`](docs/practice/properties-exceptions/practice-props-ex-01.md)<br>[`docs/practice/properties-exceptions/practice-props-ex-02.md`](docs/practice/properties-exceptions/practice-props-ex-02.md) | [`src/labs/04-properties-exceptions/CS1302.Lab04.PropertiesExceptions/`](src/labs/04-properties-exceptions/CS1302.Lab04.PropertiesExceptions/) | [`Program.cs`](src/labs/04-properties-exceptions/CS1302.Lab04.PropertiesExceptions/Program.cs)<br>[`Models/BankAccount.cs`](src/labs/04-properties-exceptions/CS1302.Lab04.PropertiesExceptions/Models/BankAccount.cs)<br>[`Models/Temperature.cs`](src/labs/04-properties-exceptions/CS1302.Lab04.PropertiesExceptions/Models/Temperature.cs) |




This repository contains CS 1302 lab materials and starter code written in C# using .NET.

## Prereqs
- .NET SDK (LTS recommended)
- VS Code + C# Dev Kit extension

Verify:
```bash
dotnet --version
```

## Repo Layout (typical)

* `docs/` – lab writeups and UML diagrams
* `src/` – lab projects + solution
* `tests/` – automated tests (if used)

## Common Commands

Build:

```bash
make build
```

Run a lab (set LAB path):

```bash
make run LAB=src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D
```

Test:

```bash
make test
```

Format:

```bash
make format
```

Clean:

```bash
make clean
```