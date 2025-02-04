# 📚 BookAPI

A simple RESTful API built using **.NET 8** and **Entity Framework Core** for managing book records. It allows users to **Create, Read, Update, and Delete (CRUD)** books in a **MySQL database**.

---

## 🚀 Features

- **CRUD operations** for managing books
- **MySQL database integration** using Entity Framework Core
- **RESTful API** with minimal API endpoints
- **Dependency Injection (DI)**
- **EF Core Migrations** for database schema management

---

## 🛠️ Tech Stack

- **.NET 8**
- **C#**
- **Entity Framework Core**
- **MySQL (via Pomelo.EntityFrameworkCore.MySql)**
- **Swagger (API documentation)**

---

## 📦 Installation & Setup

### 1️⃣ Clone the Repository  
```sh
git clone https://github.com/pavan-sumhruth/BookAPI.git
cd BookAPI
```

### 2️⃣ Install Dependencies  
```sh
dotnet restore
```

### 3️⃣ Configure MySQL Connection  
Update the `appsettings.json` file with your **MySQL** connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=bookdb;User=root;Password=root";
}
```

### 4️⃣ Apply Migrations  
```sh
dotnet ef database update
```

### 5️⃣ Run the API  
```sh
dotnet run
```

The API will start at:  
`http://localhost:5051/`

---

## 🔥 API Endpoints

| Method | Endpoint      | Description          |
|--------|-------------|----------------------|
| GET    | `/books`     | Get all books       |
| GET    | `/books/{id}` | Get a book by ID    |
| POST   | `/books`     | Add a new book      |
| PUT    | `/books/{id}` | Update a book      |
| DELETE | `/books/{id}` | Delete a book      |

### 📜 Example JSON Request (POST /books)
```json
{
  "title": "The Great Gatsby",
  "author": "F. Scott Fitzgerald"
}
```

---

---
