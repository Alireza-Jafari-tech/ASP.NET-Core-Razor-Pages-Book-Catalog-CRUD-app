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

## 🛠️ Technologies
- **ASP.NET Core 8.0** (Razor Pages)
- **Entity Framework Core** (Code-First + Migrations)
- **SQL Server** (local DB)
- **Bootstrap 5** (basic UI styling)

- ## 📸 Snapshots / Screenshots
- Home / List of Books

  <img width="1343" height="673" alt="index" src="https://github.com/user-attachments/assets/f8b3204c-538a-473b-9a83-f670224c3831" />

- create Book Page

   <img width="1343" height="902" alt="add" src="https://github.com/user-attachments/assets/a5583d81-1941-40f2-a36e-248bab2299b0" />
   
- Edit Book Page

<img width="1343" height="732" alt="edit" src="https://github.com/user-attachments/assets/95367d3a-8fff-450b-961c-421f900f0391" />

- Delete Book Page

- <img width="1343" height="1007" alt="delete (2)" src="https://github.com/user-attachments/assets/7c5b3cf6-55ab-4f90-b88b-824986b5d0c5" />

- Show Book details Page

  <img width="1343" height="1000" alt="details" src="https://github.com/user-attachments/assets/938bd858-6044-4a6e-a22f-163d43a7b84d" />
  
- - ## ⚙️ Installation & Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Alireza-Jafari-tech/ASP.NET-Core-Razor-Pages-Book-Catalog-CRUD-app.git
   cd ASP.NET-Core-Razor-Pages-Book-Catalog-CRUD-app
   ```

2. Update the connection string in appsettings.json:
   ```json
   "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BookCatalogDb;Trusted_Connection=True;TrustServerCertificate=True"}

3. Apply migrations & ensure database is up to date:
```bash
dotnet ef database update
```

4. Run the application:
```bash
dotnet run
```
Then open http://localhost:7000

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

##🎯 Learning Goals

- Understand Razor Pages structure

- Practice Model Binding and Validation

- Work with Enums in forms

- Explore EF Core CRUD operations

- Get hands-on with ASP.NET Core web development

🧑‍💻 Usage

- Use Create page to add a Book

- Use Index page to see the list of Books

- Use Edit to edit a Book

- Use Delete to remove a Book

📝 License

This project is licensed under the MIT License. See the LICENSE
 file for details

🤝 Contributing

This project is for learning purposes, but feel free to fork and improve it. Suggestions and pull requests are welcome.
