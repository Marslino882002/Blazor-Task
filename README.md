# ![Blazor Logo](https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Blazor.png/250px-Blazor.png) 

# Blazor-Task

## Overview
A full-stack Blazor WebAssembly project , The project uses a layered architecture with clean separation of concerns: Client, Server, Domain, and Infrastructure.  

> The backend API has been deployed and is accessible [here](http://blazor123.runasp.net/swagger/index.html).

---

## Architecture

### 1. Client (Blazor.Client)
- Blazor WebAssembly frontend.
- Components for displaying and adding students.
- Services to call the API (`StudentService`).

### 2. Server (Blazor.Server)
- ASP.NET Core Web API backend.
- Exposes endpoints for `Student` CRUD operations.
- Handles CORS for client access.
- Uses `Swagger` for API testing and documentation.

### 3. Domain (Blazor.Domain)
- Contains `DTOs` (Data Transfer Objects) and repository interfaces.
- Defines the business layer contracts.

### 4. Infrastructure (Blazor.Infrastructure)
- Implements repository interfaces.
- Handles database operations using `Entity Framework Core`.
- Provides the `BlazorSolutionDbContext`.

---

## Usage

1. Clone the repository:
```bash
git clone https://github.com/yourusername/Blazor-Student-Management.git
