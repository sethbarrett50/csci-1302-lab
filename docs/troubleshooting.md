# Troubleshooting

## “dotnet: command not found”
Install the .NET SDK, then restart your terminal.

## Build errors about SDK version
This repo may include a `global.json` that pins the .NET SDK version.
Run:
```bash
dotnet --info
```

If you don’t have the pinned version installed, install that SDK.

## VS Code doesn’t show IntelliSense

* Make sure C# Dev Kit is installed
* Reload window (Cmd+Shift+P → “Developer: Reload Window”)
* Ensure you opened the repository folder (not a single file)