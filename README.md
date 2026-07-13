# 🛠️ SOLID Principles & Code Smells Refactoring in C#

## 📌 Overview
This repository contains practical examples of identifying **Code Smells** and refactoring them into **Clean Architecture** using the **SOLID Principles** of Object-Oriented Design. 

The goal of these exercises is to write maintainable, scalable, and loosely coupled code in **C# / .NET**.

---

## 🚀 Projects & Refactoring Scenarios

### 1. Order Processor System (`01-OrderProcessor`)
**Violations Fixed:** * Single Responsibility Principle (SRP)
* Open/Closed Principle (OCP)
* Dependency Inversion Principle (DIP)

**Refactoring Details:**
The original `OrderProcessor` class handled business logic, database saving, and email notifications using heavily nested `if/else` statements. 
* **SRP & DIP Applied:** Extracted database and notification logic into separate interfaces (`IOrderRepository`, `INotificationService`) and injected them via Constructor Injection.
* **OCP Applied:** Created an `IOrder` interface with `DigitalOrder` and `PhysicalOrder` implementations to eliminate conditional logic and allow future order types to be added without modifying existing code.

### 2. Multi-Function Printers System (`02-Printers`)
**Violations Fixed:** * Interface Segregation Principle (ISP)
* Liskov Substitution Principle (LSP)

**Refactoring Details:**
The original system forced a `BasicPrinter` to implement a fat `IMachine` interface containing `Scan()` and `Fax()` methods, causing a `NotImplementedException` and breaking the Liskov Substitution Principle.
* **ISP Applied:** Segregated the fat interface into role-specific interfaces (`IPrinter`, `IScanner`, `IFax`).
* **LSP Applied:** The `BasicPrinter` now only implements `IPrinter`, ensuring it can seamlessly substitute its base interface without crashing the application. The `MultiFunctionPrinter` utilizes multiple interface implementation to fulfill all roles.

---

## 💻 Tech Stack
* **Language:** C#
* **Paradigm:** Object-Oriented Programming (OOP)
* **Concepts:** Clean Code, SOLID Principles, Dependency Injection (DI), Interface Segregation.

---

## 💡 How to Run
1. Clone this repository to your local machine.
2. Open the solution in **Visual Studio**.
3. Set the specific project folder as the startup project.
4. Run the application to see the polymorphic behavior in the console output.
