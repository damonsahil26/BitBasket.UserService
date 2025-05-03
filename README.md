# Bitbucket.UserService

**Bitbucket.UserService** is a microservice built with ASP.NET Core that handles user registration and authentication (login) functionalities for a distributed eCommerce system. It is part of a cloud-native microservices architecture, leveraging modern DevOps practices and scalable infrastructure.

---

## 🚀 Features

- User Registration and Login
- JWT-based Authentication
- PostgreSQL as a data store
- Dapper for lightweight data access
- FluentValidation for input validation
- AutoMapper for object mapping
- RabbitMQ for service communication
- Redis for caching
- Resilience with Polly (retry, circuit breaker)
- Dockerized & Orchestrated using Kubernetes (AKS)
- CI/CD with Azure DevOps
- Interactive API documentation via Swagger

---

## 🛠️ Tech Stack

- **.NET 8**
- **PostgreSQL**
- **Dapper**
- **FluentValidation**
- **AutoMapper**
- **RabbitMQ**
- **Redis**
- **Docker & Kubernetes (AKS)**
- **Azure DevOps**

---

## 📦 API Endpoints

### 🔐 Register User

- **URL:** `POST /api/users/register`
- **Description:** Registers a new user in the system.
- **Request Body:**
```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com",
  "password": "SecurePassword123!"
}
```
## 🔑 Login User

- **URL:** `POST /api/users/login`
- **Description:** Authenticates a user and returns a JWT token.

### 📝 Request Body

```json
{
  "email": "john.doe@example.com",
  "password": "SecurePassword123!"
}
```
