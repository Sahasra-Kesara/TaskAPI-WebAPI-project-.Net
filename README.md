# ASP.NET Core Web API Tutorial Series

This repository contains code examples and demos for learning the basics of ASP.NET Core Web API development. The tutorials in this series are aimed at helping you understand and implement RESTful API endpoints, as well as apply core ASP.NET principles and patterns to create efficient and maintainable applications.

## Technologies Used
- **ASP.NET Core 5.x**: For creating RESTful Web APIs.
- **Visual Studio 2019 Community Edition**: For development, debugging, and Git integration.
- **Entity Framework (EF) Core 5**: For data persistence and interaction with SQL Server.
- **AutoMapper**: For object-to-object mapping, allowing seamless data transfer between different layers.
- **GitHub**: Code repository management and version control with Visual Studio GitHub extension.

## Key Features and Patterns
1. **Action Results & Methods**
   - Return various types of responses using `IActionResult` and `ActionResult<T>`.
   - Implement methods for common HTTP verbs: `GET`, `POST`, `PUT`, and `DELETE`.

2. **Endpoints & Parameters**
   - Create API endpoints with route parameters and query strings.
   - Filter and search data using query parameters.

3. **Dependency Injection**
   - Inject services and repositories into controllers for separation of concerns.
   - Configure services in `Startup.cs` to facilitate DI throughout the application.

4. **Repository Pattern**
   - Encapsulate data access logic and separate it from the business logic.
   - Create interfaces and classes for repositories to handle CRUD operations.

5. **EF Core Integration**
   - Set up Entity Framework Core to connect to SQL Server.
   - Define data models and use migrations to manage database schema.

6. **Status Codes and Headers**
   - Use appropriate HTTP status codes for different actions (`200 OK`, `201 Created`, `400 Bad Request`, `404 Not Found`, `500 Internal Server Error`, etc.).
   - Configure and validate Accept headers for better API consumer experience.

7. **Object Mapping**
   - Use AutoMapper to convert data between DTOs and domain models.
   - Map responses efficiently to reduce boilerplate code.

8. **GitHub Integration**
   - Use Visual Studio GitHub extension for version control and collaboration.
   - Clone, create branches, commit, and push changes directly from Visual Studio.

9. **Error Handling**
   - Send custom error messages to API consumers.
   - Implement error handling middleware for a consistent error format.

10. **Resource Management**
    - Create and update resources, handling relationships between parent and child resources.
    - Implement `PATCH` and `DELETE` for resource updates and deletions, following REST principles.

## Getting Started
1. Clone this repository using Visual Studio's GitHub extension.
2. Switch to the appropriate branch for each tutorial part.
3. Follow along with the code examples to understand how to build and test each component.

## Requirements
- **.NET SDK**: .NET 5.x
- **SQL Server**: For data storage
- **Postman or Swagger UI**: For testing endpoints

## Tutorial Parts
Each branch represents a part of the tutorial:
1. **Part 1**: Basic setup and introduction to Action Results.
2. **Part 2**: Implementing the Repository Pattern and Dependency Injection.
3. **Part 3**: Connecting with SQL Server using EF Core.
4. **Part 4**: Managing status codes and headers.
5. **Part 5**: Implementing AutoMapper and error handling.
6. **Part 6**: Using query strings for data filtering.
7. **Part 7**: Creating parent-child resources.
8. **Part 8**: Updating and deleting resources.
