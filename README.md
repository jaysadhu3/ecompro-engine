[![.NET](https://img.shields.io/badge/.NET-9-blue)](https://dotnet.microsoft.com/)
[![Angular](https://img.shields.io/badge/Angular-19-red)](https://angular.io/)
[![License](https://img.shields.io/badge/license-MIT-green)](https://github.com/jaysadhu3/ecompro-engine/blob/main/LICENSE)
[![Status](https://img.shields.io/badge/status-In%20Development-orange)](https://github.com/jaysadhu3/ecompro-engine)

## 🚀 EcomPro Engine

A Production-Ready Angular + .NET 9 E-Commerce Engine
Built with Clean Architecture, Scalability & Customization in mind.

## 📌 Overview

<b> EcomPro Engine </b> is a modern, enterprise-grade e-commerce backend and frontend system designed to be:
- 🔥 Customizable
- ⚡ Scalable
- 🧱 Modular
- 🛡 Secure
- 💼 Sellable as a product

This project is being built as a real-world commercial product — not just a demo application.

## 🛠 Tech Stack
<b>Backend</b>
- .NET 9
- ASP.NET Core Web API
- Clean Architecture
- Entity Framework Core
- SQL Server
- JWT Authentication
- MediatR (CQRS)
- FluentValidation
- Serilog Logging

<b>Frontend</b>
- Angular 19
- Angular Material
- SCSS
- Responsive Layout
- Role-based UI

<b>Database</b>
- SQL Server Express (Development)
- Designed for production scalability

## 🏗 Architecture

This project follows <b>Clean Architecture principles:</b>
```
API → Application → Domain
API → Infrastructure
Infrastructure → Application
Infrastructure → Domain
```
<b>Solution Structure</b>
```
EcomPro
 ├── EcomPro.API
 ├── EcomPro.Application
 ├── EcomPro.Domain
 ├── EcomPro.Infrastructure
 ```
## 🎯 Key Features (Planned & In Progress)
- ✅ Product Management
- ✅ Category Management
- ✅ Cart & Order Flow
- 🔐 Authentication & Authorization (JWT)
- 🎨 Dynamic Store Settings
- 🛒 Coupon System
- 📊 Admin Dashboard
- 📦 Inventory Tracking
- 💳 Payment Integration (Pluggable)
- 📄 Invoice Generation
- 📈 Analytics
- ⚙ Feature Toggles
- 🌗 Dark / Light Mode Support

## 🧠 Product Philosophy

This is not a simple e-commerce app.

It is being built as:
```
A configurable, modular, and scalable e-commerce engine that can evolve into a SaaS-ready system.
```
#### Core principles:
- No hardcoded values
- Configuration-driven features
- Role-based access
- Extendable modules
- Production-level structure from Day 1

## 🔐 Security Considerations
- No secrets stored in repository
- Environment-based configuration
- JWT-based authentication
- Role-based authorization
- Secure database access
- Branch protection enabled

## 🚀 Getting Started (Backend)
### 1️⃣ Clone the repository
```bash
git clone https://github.com/YOUR_USERNAME/ecompro-engine.git
cd ecompro-engine
```
### 2️⃣ Configure database

Update your connection string locally using:
```bash
dotnet user-secrets
```
### 3️⃣ Run migrations
```bash
dotnet ef database update
```
### 4️⃣ Run API
```bash
dotnet run
```
Swagger will open automatically.

## 📌 Development Status

This project is under active development.

The goal is to evolve it into:
- A complete sellable e-commerce product
- A SaaS-ready platform
- A portfolio-level production system

## 📄 License

MIT License

## 👨‍💻 Author

Developed by Jay Sadhu  
Software Engineer | .NET & Angular Developer


