SHELL := /bin/bash
DOTNET ?= dotnet
DOTNET_TOOL ?= $(DOTNET) tool

# Path to solution
SLN ?= src/CS1302.Labs.slnx

# LAB points to a project directory or .csproj.
# Example:
#   make run LAB=src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D
#   make run LAB=src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/CS1302.Lab02.Arrays1D.csproj
LAB ?=

# For new lab creation:
NUM ?=
SLUG ?=
NAME ?=

# Configuration can be Debug/Release
CONFIG ?= Debug

.DEFAULT_GOAL := help

help:
	@echo "Common targets:"
	@echo "  make restore              Restore NuGet packages"
	@echo "  make build                Build solution (CONFIG=$(CONFIG))"
	@echo "  make test                 Run tests"
	@echo "  make run LAB=path          Run a lab project (dir or .csproj)"
	@echo "  make clean                Clean solution"
	@echo "  make rebuild              Clean + build"
	@echo "  make list                 List projects in solution (if supported)"
	@echo "  make info                 Print dotnet info"
	@echo "  make tree                 Show repo tree (excludes bin/obj/etc.)"
	@echo "  make new-lab NUM= NN SLUG=... NAME=...   Create a new lab + add to solution"
	@echo "  make bootstrap            Restore deps + sanity info"
	@echo "  make ci                   Run what CI runs (restore+build+test)"
	@echo "  make tool-restore          Restore dotnet tools (CSharpier)"
	@echo "  make format                Auto-format code (CSharpier)"
	@echo "  make lint                  Check formatting + build (no changes)"



	@echo ""
	@echo "Examples:"
	@echo "  make build"
	@echo "  make test"
	@echo "  make run LAB=src/labs/03-arrays-2d/CS1302.Lab03.Arrays2D"
	@echo "  make run LAB=src/labs/03-arrays-2d/CS1302.Lab03.Arrays2D/CS1302.Lab03.Arrays2D.csproj"

info:
	$(DOTNET) --info

restore:
	$(DOTNET) restore "$(SLN)"

build:
	$(DOTNET) build "$(SLN)" -c "$(CONFIG)" --nologo

test:
	$(DOTNET) test "$(SLN)" -c "$(CONFIG)" --nologo

clean:
	$(DOTNET) clean "$(SLN)" -c "$(CONFIG)" --nologo

rebuild: clean build

list:
	$(DOTNET) sln "$(SLN)" list

bootstrap:
	@./scripts/bootstrap.sh "$(SLN)"

ci: restore build test

tool-restore:
	$(DOTNET_TOOL) restore

format: tool-restore
	$(DOTNET) csharpier format .

lint: format tool-restore
	$(DOTNET) csharpier check .
	$(DOTNET) build "$(SLN)" -c "$(CONFIG)" --nologo

run:
	@if [ -z "$(LAB)" ]; then \
		echo "ERROR: LAB is required."; \
		echo "Usage: make run LAB=src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D"; \
		exit 2; \
	fi
	@if [ -d "$(LAB)" ]; then \
		$(DOTNET) run --project "$(LAB)" -c "$(CONFIG)" --no-launch-profile; \
	else \
		$(DOTNET) run --project "$(LAB)" -c "$(CONFIG)" --no-launch-profile; \
	fi

tree:
	@if command -v tree >/dev/null 2>&1; then \
		tree -a -I ".git|bin|obj|.vs|.vscode|TestResults|node_modules|.DS_Store" ; \
	else \
		echo "NOTE: 'tree' not installed. Using 'find' fallback (install with: brew install tree)"; \
		find . \
			\( -name .git -o -name bin -o -name obj -o -name .vs -o -name .vscode -o -name TestResults -o -name node_modules \) -prune -o \
			-print | sed 's|[^/]*/|  |g;s|  |│ |g;s|│ \([^│]\)|├─ \1|'; \
	fi

# Create a new lab project and add it to the solution.
# Usage:
#   make new-lab NUM=02 SLUG=arrays-1d NAME=Arrays1D
# Produces:
#   src/labs/02-arrays-1d/CS1302.Lab02.Arrays1D/...
new-lab:
	@if [ -z "$(NUM)" ] || [ -z "$(SLUG)" ] || [ -z "$(NAME)" ]; then \
		echo "ERROR: NUM, SLUG, and NAME are required."; \
		echo "Usage: make new-lab NUM=02 SLUG=arrays-1d NAME=Arrays1D"; \
		exit 2; \
	fi
	@LAB_DIR="src/labs/$(NUM)-$(SLUG)/CS1302.Lab$(NUM).$(NAME)"; \
	echo "Creating lab at $$LAB_DIR"; \
	mkdir -p "$$LAB_DIR"; \
	$(DOTNET) new console -n "CS1302.Lab$(NUM).$(NAME)" -o "$$LAB_DIR"; \
	$(DOTNET) sln "$(SLN)" add "$$LAB_DIR/CS1302.Lab$(NUM).$(NAME).csproj"; \
	echo "Done."