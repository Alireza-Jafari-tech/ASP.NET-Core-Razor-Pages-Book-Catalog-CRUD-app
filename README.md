# 📚 Book Catalog (ASP.NET Core Razor Pages)

A simple CRUD (Create, Read, Update, Delete) web application built with **ASP.NET Core Razor Pages** and **Entity Framework Core**.  
This project is part of my learning journey into ASP.NET Core, focusing on data modeling, server-side validation, and Razor Pages fundamentals.

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-green.svg)](https://learn.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-red.svg)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A week-long learning project focused on ASP.NET Core Razor Pages + Entity Framework Core + SQL Server.  
This project captures the fundamentals: setting up the database, using migrations, and implementing CRUD operations with validation.

## 🚀 Features
- Add new books with validation
- Edit book details
- View full book details
- Delete books with confirmation
- Automatic calculation of **Sell Price** based on discount
- Enum-based support for multiple languages (English, فارسی, العربية, Français)

---

## 🛠️ Technologies
- **ASP.NET Core 8.0** (Razor Pages)
- **Entity Framework Core** (Code-First + Migrations)
- **SQL Server** (local DB)
- **Bootstrap 5** (basic UI styling)

---

- ## 📸 Snapshots / Screenshots

- - ## ⚙️ Installation & Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Alireza-Jafari-tech/Razor-Pages-Fundamentals-Week-2.git
   cd Razor-Pages-Fundamentals-Week-2
   ```

2. Update the connection string in appsettings.json:
   ```json
   "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=TaskManagmentDb;Trusted_Connection=True;TrustServerCertificate=True"}

3. Apply migrations & ensure database is up to date:
```bash
dotnet ef database update
```

4. Run the application:
```bash
dotnet run
```

📂 Project Structure
```pgsql
/Pages
/Books
- Index.cshtml → List of books
- Create.cshtml → Add new book
- Edit.cshtml → Update book
- Delete.cshtml → Delete confirmation
- Details.cshtml → View details
/Data

AppDbContext.cs → EF Core DbContext
/Model

Book.cs → Book entity

ELanguage.cs → Supported languages enum
```

---

## 📂 Project Structure
