
# CLI Task Manager

A lightweight CLI application for task management and productivity tracking built with **C#** and **.NET**. Designed with object-oriented architecture, strong decoupling, and local persistence.

---

## Features

- **Task Management**: Create, view, update, and delete tasks (CRUD).
- **Status & Priority Tracking**: Mark tasks as pending, in-progress, or completed; set priority levels.
- **Data Persistence**: Tasks are persisted locally (JSON storage), preserving state between CLI sessions.
- **Argument Parsing**: Clean and simple command syntax with structured validation and error handling.
- **Maintainable Architecture**: Built following SOLID principles and clean code practices.

---

## Tech Stack & Architecture

- **Language:** C# 12 / .NET 8 (or your version)
- **Persistence:** Local file storage (`System.Text.Json` / file I/O)
- **Patterns & Principles:** Repository Pattern, Single Responsibility, Separation of Concerns
- **Testing:** Unit tests covering core task logic and state transitions

### Project Structure

```text
CLI-Task-Manager/
├── src/
│   ├── Core/           # Domain models (TaskItem, TaskStatus, Priority)
│   ├── Storage/        # Persistence logic & repository implementation
│   ├── Services/       # Business logic & task operations
│   └── UI/             # CLI commands, argument parsing, console output
├── tests/              # Unit tests
└── README.md
```


Getting Started
Prerequisites

    .NET SDK (version 8.0 or later)
    Git

Installation & Build

    Clone the repository:
    Bash

    git clone [https://github.com/solfaron/CLI-Task-Manager.git](https://github.com/solfaron/CLI-Task-Manager.git)
    cd CLI-Task-Manager

    Restore dependencies & build:
    Bash

    dotnet build

    Run the application:
    Bash

    dotnet run --project src/CLI-Task-Manager

Usage Examples

(Adjust the command names below to match your exact CLI syntax)

    Add a new task:
    Bash

    task-cli add "Implement unit tests for file parser" --priority high

    List all tasks:
    Bash

    task-cli list

    Filter tasks by status:
    Bash

    task-cli list --status pending

    Mark a task as completed:
    Bash

    task-cli complete <task-id>

    Delete a task:
    Bash

    task-cli delete <task-id>


Project Supplied By https://roadmap.sh/projects/task-tracker
