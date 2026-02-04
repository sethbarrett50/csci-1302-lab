# CS 1302 Labs (C#/.NET)

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