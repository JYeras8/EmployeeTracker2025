# EmployeeTracker2025

EmployeeTracker2025 is a Windows Forms application for managing employees, departments,
permissions, salaries and tasks.  It is structured as a traditional three‑project
solution consisting of a presentation layer (`PersonelTracking`), a business layer
(`BLL`) and a data access layer (`DAL`) using Entity Framework Core and SQL Server.

## Prerequisites

- .NET 9.0 SDK
- Visual Studio 2022 (or later) or the `dotnet` CLI
- SQL Server instance for the application database

## Build and Run

1. Clone the repository.

```bash
 git clone <repo-url>
```

2. Configure your connection string in
   `PersonelTracking/appsettings.json` to point to your SQL Server
   instance.

3. Restore and build the solution.

```bash
 dotnet build PersonelTracking.sln
```

   You can also open `PersonelTracking.sln` in Visual Studio and build
   from the IDE.

4. Run the Windows Forms application.

```bash
 dotnet run --project PersonelTracking
```

   Alternatively start the project from Visual Studio.

The repository includes some SQL scripts in the root directory that may
be useful for populating or testing the database.

