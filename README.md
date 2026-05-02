# 🛒 E-Store API

A fully-featured **E-Commerce REST API** built with **ASP.NET Core 8** following **Clean Architecture** principles.

---

## 📋 Table of Contents

- [About](#about)
- [Architecture](#architecture)
- [Features](#features)
- [Technologies](#technologies)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Authentication](#authentication)
- [Contributing](#contributing)

---

## 📖 About

E-Store is a production-ready REST API for an e-commerce platform. It supports product browsing, cart management, checkout, order tracking, and user authentication — all built with clean, maintainable architecture.

---

## 🏗️ Architecture

This project follows **Clean Architecture** with the following layers:

```
E-Store/
├── Core/                   # Domain + Services + Contracts
│   ├── Domain/             # Entities, Enums
│   ├── Services/           # Business Logic
│   └── ServicesAbstractions/ # Interfaces
├── Infrastructure/         # Data Access Layer
│   ├── Persistance/        # DbContext, Repositories, Migrations
│   └── Configuration/      # Entity Configurations
├── Shared/                 # DTOs, Requests, Responses
└── E-Store/                # Presentation Layer (Controllers)
```

### Design Patterns Used
- ✅ **Repository Pattern** — Generic + Specific Repositories
- ✅ **Service Manager Pattern** — Lazy Loading Services
- ✅ **DTO Pattern** — Separation between Domain and API
- ✅ **Unit of Work** — via SaveChangesAsync
- ✅ **Clean Architecture** — Separation of Concerns

---

## ✨ Features

| Feature | Description |
|---|---|
| 🔐 Authentication | Register, Login with JWT Tokens |
| 🛍️ Product Catalogue | Browse, Filter by Category/Brand, Pagination |
| 🏷️ Brand Management | Full CRUD |
| 📂 Category Management | Full CRUD |
| 🛒 Shopping Cart | Add, Remove, View Cart Items |
| 💳 Checkout | Place orders with Payment Method |
| 📦 Order Management | View Orders with Pagination |
| 📍 Address Management | Manage Delivery Addresses |

---

## 🛠️ Technologies

- **Framework:** ASP.NET Core 8
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **Authentication:** JWT Bearer + ASP.NET Identity
- **Mapping:** AutoMapper
- **Documentation:** Swagger / OpenAPI
- **Architecture:** Clean Architecture

---

## 📁 Project Structure

```
Core/
├── Domain/
│   └── Entities/
│       ├── ProductModule/     # Product, Brand, Category
│       ├── Cart/              # Cart, CartItem
│       ├── Order/             # Order, OrderItem
│       ├── Customer/          # Customer, Person
│       └── Address/           # Address
├── Services/
│   ├── ProductService.cs
│   ├── BrandService.cs
│   ├── CategoryService.cs
│   ├── CartService.cs
│   ├── CheckoutService.cs
│   ├── OrderService.cs
│   ├── CatalogueService.cs
│   └── AuthenticationService.cs
└── ServicesAbstractions/
    ├── IProductService.cs
    ├── IBrandService.cs
    └── ...

Infrastructure/
└── Persistance/
    ├── Data/
    │   └── EStoreDbContext.cs
    ├── Repositories/
    │   ├── GenericRepository.cs
    │   ├── CartRepository.cs
    │   ├── OrderRepository.cs
    │   └── ...
    └── Migrations/

Shared/
├── DTOS/
├── Contracts/
│   ├── Request/
│   └── Response/
└── ResponseBase.cs

E-Store/
└── Controllers/
    ├── AuthController.cs
    ├── ProductController.cs
    ├── BrandController.cs
    ├── CategoryController.cs
    ├── CartController.cs
    ├── CheckoutController.cs
    └── OrderController.cs
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/a7medelsadany/E-Store.git
cd E-Store
```

2. **Update appsettings.json**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=EStoreDb;Trusted_Connection=True;"
  },
  "JWTOptions": {
    "SecretKey": "YourSuperSecretKeyHereMustBe32CharactersMin",
    "Issuer": "EStoreApi",
    "Audience": "EStoreClient"
  }
}
```

3. **Apply Migrations**
```bash
cd Infrastructure
dotnet ef database update
```

4. **Run the project**
```bash
cd E-Store
dotnet run
```

5. **Open Swagger**
```
https://localhost:{port}/swagger
```

---

## 📡 API Endpoints

### 🔐 Authentication
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| POST | `/api/authentication/register` | Register new user | ❌ |
| POST | `/api/authentication/login` | Login & get JWT Token | ❌ |
| GET | `/api/authentication/current-user` | Get current user | ✅ |
| GET | `/api/authentication/roles` | Get user roles | ✅ |

### 🛍️ Products
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| GET | `/api/product` | Get all products (with filter & pagination) | ❌ |
| GET | `/api/product/{id}` | Get product by ID | ❌ |
| POST | `/api/product` | Create product | ✅ |
| PUT | `/api/product/{id}` | Update product | ✅ |
| DELETE | `/api/product/{id}` | Delete product | ✅ |

### 🏷️ Brands
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| GET | `/api/brand` | Get all brands | ❌ |
| GET | `/api/brand/{id}` | Get brand by ID | ❌ |
| POST | `/api/brand` | Create brand | ✅ |
| PUT | `/api/brand/{id}` | Update brand | ✅ |
| DELETE | `/api/brand/{id}` | Delete brand | ✅ |

### 📂 Categories
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| GET | `/api/category` | Get all categories | ❌ |
| GET | `/api/category/{id}` | Get category by ID | ❌ |
| POST | `/api/category` | Create category | ✅ |
| PUT | `/api/category/{id}` | Update category | ✅ |
| DELETE | `/api/category/{id}` | Delete category | ✅ |

### 🛒 Cart
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| GET | `/api/cart` | Get current cart | ✅ |
| POST | `/api/cart` | Add item to cart | ✅ |
| DELETE | `/api/cart/{cartId}/{cartItemId}` | Remove item from cart | ✅ |

### 💳 Checkout
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| POST | `/api/checkout` | Process checkout | ✅ |

**Request Body:**
```json
{
  "customerId": 1,
  "addressId": 1,
  "uniqueCartId": "your-cart-id",
  "paymentMethod": 1
}
```

### 📦 Orders
| Method | Endpoint | Description | Auth |
|---|---|---|---|
| GET | `/api/order` | Get all orders (paginated) | ✅ |
| GET | `/api/order/{id}` | Get order by ID | ✅ |

---

## 🔐 Authentication

This API uses **JWT Bearer Authentication**.

### How to use:

1. Register or Login to get a token
2. Add the token to your request headers:
```
Authorization: Bearer {your-token}
```

### Payment Methods
```
0 = Cash
1 = CreditCard
2 = DebitCard
3 = Visa
4 = MasterCard
```

---

## 🗃️ Database Schema

```
ApplicationUser (Identity)
    ↓
Customer ──── Address
    ↓
Order ──── OrderItem ──── Product
                              ↑
Brand ────────────────────────┤
Category ─────────────────────┘

Cart ──── CartItem ──── Product
```

---

## 👤 Author

**Ahmed Elsadany**

- GitHub: [@a7medelsadany](https://github.com/a7medelsadany)

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).
