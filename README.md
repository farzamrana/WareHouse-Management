# Warehouse Management System

A robust ASP.NET Core Web API for managing warehouse operations with user authentication and inventory tracking.

## Features

- 🔐 JWT Authentication
- 📦 Product Management
- 📁 Category Management
- 📊 Inventory Tracking
- 📝 Transaction History
- 🔍 Swagger UI Documentation
- 💾 SQL Server Database

## Prerequisites

- .NET 8.0 SDK
- SQL Server (LocalDB or SQL Server Express)
- Visual Studio 2022 or later (recommended)

## Getting Started

1. Clone the repository:
```bash
git clone https://github.com/yourusername/warehouse-management.git
cd warehouse-management
```

2. Update the connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=WarehouseManagement;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
}
```

3. Run the database migrations:
```bash
cd WebApplication90
dotnet ef database update
```

4. Run the application:
```bash
dotnet run
```

5. Access the Swagger UI at: `https://localhost:5001`

## API Endpoints

### Authentication
- `POST /api/Auth/register` - Register a new user
- `POST /api/Auth/login` - Login and get JWT token

### Categories
- `GET /api/Categories` - Get all categories
- `GET /api/Categories/{id}` - Get category by ID
- `POST /api/Categories` - Create new category
- `PUT /api/Categories/{id}` - Update category
- `DELETE /api/Categories/{id}` - Delete category

### Products
- `GET /api/Products` - Get all products
- `GET /api/Products/{id}` - Get product by ID
- `POST /api/Products` - Create new product
- `PUT /api/Products/{id}` - Update product
- `DELETE /api/Products/{id}` - Delete product
- `POST /api/Products/{id}/stock-in` - Add stock
- `POST /api/Products/{id}/stock-out` - Remove stock

### Transactions
- `GET /api/Transactions` - Get all transactions
- `GET /api/Transactions/{id}` - Get transaction by ID
- `GET /api/Transactions/product/{productId}` - Get transactions for a product
- `GET /api/Transactions/date-range` - Get transactions by date range

## Authentication

The API uses JWT (JSON Web Token) for authentication. To use protected endpoints:

1. Register a user using the `/api/Auth/register` endpoint
2. Login using the `/api/Auth/login` endpoint to get a JWT token
3. Include the token in the Authorization header: `Bearer your-token-here`

## Example Requests

### Register User
```json
POST /api/Auth/register
{
    "email": "user@example.com",
    "password": "YourPassword123!"
}
```

### Create Category
```json
POST /api/Categories
{
    "name": "Electronics",
    "description": "Electronic devices and accessories"
}
```

### Create Product
```json
POST /api/Products
{
    "name": "Laptop",
    "description": "High-performance laptop",
    "price": 999.99,
    "quantity": 10,
    "categoryId": 1
}
```

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


## Acknowledgments

- ASP.NET Core
- Entity Framework Core
- JWT Authentication
- Swagger/OpenAPI
