#!/usr/bin/env bash
set -euo pipefail

SLN="${1:-src/CS1302.Labs.slnx}"

echo "[bootstrap] dotnet version:"
dotnet --version
echo

echo "[bootstrap] restoring solution: ${SLN}"
dotnet restore "${SLN}"

echo
echo "[bootstrap] done."
