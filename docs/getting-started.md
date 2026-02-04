# Getting Started (VS Code + Mac)

## Install
- Install the .NET SDK (LTS recommended)
- Install VS Code extensions:
  - C# Dev Kit

## Verify
Open a terminal and run:
```bash
dotnet --version
```

## Common commands (from repo root)

```bash
make build
make test
```

Once we add `src/`, you’ll also be able to run a practice lab like:

```bash
make run LAB=src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D
```