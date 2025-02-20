The .NET CLI (Command-Line Interface) is a powerful tool for building, running, and managing .NET applications efficiently. Here’s a list of 30 must-know commands to enhance your productivity:

 1. dotnet new console: Creates a new console application project.
 2. dotnet build: Builds the project and generates the output (DLL or EXE).
 3. dotnet run: Runs the application from the source code without explicitly building it.
 4. dotnet clean: Cleans the output of the project, removing all build artifacts.
 5. dotnet publish: Publishes the application for deployment by compiling and copying all necessary files.
 6. dotnet test: Runs all the unit tests in the specified project.
 7. dotnet add package [PackageName]: Adds a NuGet package to your project.
 8. dotnet restore: Restores the dependencies and project-specific tools.
 9. dotnet tool install -g [ToolName]: Installs a global tool for .NET.
 10. dotnet tool update -g [ToolName]: Updates a globally installed tool.
 11. dotnet tool list -g: Lists all globally installed tools.
 12. dotnet remove package [PackageName]: Removes a specified NuGet package from your project.
 13. dotnet list package: Lists all the NuGet packages installed in your project.
 14. dotnet migrate: Migrates a project.json-based project to a .csproj-based one.
 15. dotnet watch run: Watches the file system for changes and restarts the application automatically.
 16. dotnet watch test: Runs tests and re-runs them whenever the code changes.
 17. dotnet sln add [ProjectPath]: Adds a project to the solution file.
 18. dotnet sln remove [ProjectPath]: Removes a project from the solution file.
 19. dotnet pack: Creates a NuGet package from the project.
 20. dotnet help: Provides help and documentation for .NET CLI commands.
 21. dotnet list reference: Lists all the project-to-project references in your project.
 22. dotnet add reference [ProjectPath]: Adds a reference to another project.
 23. dotnet remove reference [ProjectPath]: Removes a reference to another project.
 24. dotnet msbuild: Builds a project using MSBuild with custom parameters.
 25. dotnet --version: Displays the installed .NET version.
 26. dotnet new mvc: Creates a new ASP.NET Core MVC project.
 27. dotnet new api: Creates a new ASP.NET Core Web API project.
 28. dotnet dev-certs https --trust: Sets up HTTPS development certificates.
 29. dotnet user-secrets init: Initializes user secrets for a project.
 30. dotnet ef migrations add [Name]: Adds a new Entity Framework migration to the project.