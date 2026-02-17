🚀 Dotnet API – API to API Communication (Microservice Pattern)

This solution demonstrates how to implement API-to-API communication in ASP.NET Core using HttpClient, Dependency Injection, and a clean layered architecture.

The solution contains two independent Web API projects:

📂 Project Structure
🔹 1️⃣ Dotnet_API_14_API_2_API-call (Primary API)

Exposes hotel data via:

GET /api/Hotel/GetAllHotels


Implements:

Controller layer

Service layer

DTO mapping

Dependency Injection

Swagger documentation

🔹 2️⃣ 2nd_API_ (Consumer API)

Calls the first API using HttpClient

Exposes:

GET /api/Report/GetHotelReport


Returns:

Total hotel count

Full hotel list from external API

Implements:

Interface-based service layer

External API service abstraction

Configuration-based Base URL

Clean separation of concerns

🏗 Architecture Overview
2nd_API_ (Consumer API)
        ↓
ExternalHotelService (HttpClient)
        ↓
Primary Hotel API
        ↓
Service Layer
        ↓
Database

⚙️ Technologies Used

ASP.NET Core 8 Web API

Dependency Injection

HttpClient Factory

Swagger (OpenAPI)

Clean Architecture Principles

RESTful API Design

🎯 Key Concepts Demonstrated

API-to-API communication

Service abstraction

Loose coupling via interfaces

Environment-based configuration

Scalable microservice-ready structure

Proper dependency injection usage

🔥 How to Run

Run Primary API first

Run 2nd_API_

Access:

https://localhost:{port}/api/Report/GetHotelReport

📌 Future Enhancements

Polly Retry Policy

Circuit Breaker Pattern

Logging with Serilog

Caching with Redis

JWT Authentication between APIs

API Gateway implementation

✅ 📦 Professional Commit Message
Standard Clean Commit
feat: implement API-to-API communication using HttpClient with clean architecture structure

More Detailed Version (Recommended)
feat: add second API project with external service integration

- Implemented HttpClient-based API communication
- Added IExternalHotelService abstraction
- Created ReportController for aggregated hotel report
- Configured DI and HttpClient factory
- Structured solution with clean layered architecture
