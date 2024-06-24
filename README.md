# RonieProjecsHomeTest Project

## Description

**RonieProjecsHomeTest** is a .NET 8.0 console application designed to fetch user data from various API sources and save the aggregated data in different file formats (JSON, CSV). The application prompts the user for the folder path and desired file format before saving the data.

## Author

Orel Aviad

## Methodologies Used
### 1. Object-Oriented Programming (OOP)
1) Encapsulation
2. Inheritance
3. Polymorphism
4. Abstraction
### 2. Asynchronous Programming
- Utilized asynchronous methods (`async` and `await`) to ensure non-blocking operations while fetching data from multiple APIs, improving the application's responsiveness and performance.

### 3. SOLID Principles
- **Single Responsibility Principle**: Divided the project into classes with distinct responsibilities (`User`, `DataFetcher`, `FileSaver`).

### 4. Dependency Injection
- Though not implemented in this basic version, the design can easily integrate dependency injection to manage dependencies like `HttpClient`.
### 5. Json serialization

### 6. Json deserialization

## Getting Started

### Prerequisites

- .NET 8.0 SDK installed on your machine.

### Installation

1. Clone the repository:
    git clone https://github.com/orel0007/RonieProjecsHomeTest.git
2. Navigate to the project directory:
    cd RonieProjecsHomeTest

### Running the Application

1.dotnet add package System.Text.Json
2.dotnet add package CsvHelper
3.   Build the project:
    dotnet build
4. Run the project:
    dotnet run
5. Follow the prompts to enter the folder path and desired file format (json/csv).

### Add another fetch steps
1. cretae new user derive from user if is data store diffrently for serilzaion.
2. crate async fetch funtion in fetch users
3. Add 1 code line in progrm.cs call this fetch function.
   
### Project Structure
>>>>>>> Main
