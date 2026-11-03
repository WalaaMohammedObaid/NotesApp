# 📝 NotesApp – Notes Management System

A web-based Notes Management Application built with **ASP.NET Core MVC** and **Entity Framework Core**. The application allows users to create, view, edit, delete, and search notes through a simple and user-friendly interface.

## ✨ Features

- **Create Notes:** Add new notes with a title and content.
- **View Notes:** Display all saved notes, ordered by creation date.
- **Edit Notes:** Update existing notes.
- **Delete Notes:** Remove notes from the database.
- **Search Notes:** Search notes by title or content.
- **Input Validation:** Validate required fields and limit title length.
- **Database Integration:** Persist notes using SQL Server and Entity Framework Core.
- **Date Tracking:** Automatically record the creation date of each note.

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| C# | Backend programming |
| ASP.NET Core MVC | Web application framework |
| Entity Framework Core | ORM and database operations |
| SQL Server | Relational database |
| LINQ | Data querying and filtering |
| HTML / CSS | Frontend structure and styling |
| Bootstrap | Responsive UI components |

## 🏗️ Project Structure

```text
NotesApp/
│
├── Controllers/
│   ├── HomeController.cs
│   └── NotesController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
│
├── Models/
│   ├── Note.cs
│   └── ErrorViewModel.cs
│
├── Views/
│   ├── Notes/
│   ├── Home/
│   └── Shared/
│
├── wwwroot/
│
├── Program.cs
├── appsettings.json
└── NotesApp.csproj
```

## ⚙️ Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 8 SDK
- SQL Server
- SQL Server Management Studio (SSMS)

### 1. Clone the Repository

```bash
git clone https://github.com/WalaaMohammedObaid/NotesApp.git
```

### 2. Navigate to the Project

```bash
cd NotesApp
```

### 3. Configure the Database

Add your SQL Server connection string to your local configuration.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_SQL_SERVER_CONNECTION_STRING"
  }
}
```

Do not commit real database credentials to GitHub.

### 4. Apply Database Migrations

```bash
dotnet ef database update
```

### 5. Run the Application

```bash
dotnet run
```

Open the local URL displayed in the terminal.

## 🎯 Project Goals

This project was developed to practice ASP.NET Core MVC fundamentals, database integration, Entity Framework Core, CRUD operations, and implementing search and validation functionality in a web application.

## 👩‍💻 Developer

**Walaa Mohammed Obaid**

Backend Developer | ASP.NET Core & C#

[GitHub Profile](https://github.com/WalaaMohammedObaid)

[Project Repository](https://github.com/WalaaMohammedObaid/NotesApp)
