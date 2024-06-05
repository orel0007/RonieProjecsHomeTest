# User Aggregator

## Description

**User Aggregator** is a .NET 8.0 console application designed to fetch user data from various API sources and save the aggregated data in different file formats (JSON, CSV). The application prompts the user for the folder path and desired file format before saving the data.

## Author

Orel Aviad

## Methodologies Used

### 1. Object-Oriented Programming (OOP)

### 2. Asynchronous Programming
- Utilized asynchronous methods (`async` and `await`) to ensure non-blocking operations while fetching data from multiple APIs, improving the application's responsiveness and performance.

### 3. SOLID Principles
- **Single Responsibility Principle**: Divided the project into classes with distinct responsibilities (`User`, `DataFetcher`, `FileSaver`).

### 4. Dependency Injection
- Though not implemented in this basic version, the design can easily integrate dependency injection to manage dependencies like `HttpClient`.

## Getting Started

### Prerequisites

- .NET 8.0 SDK installed on your machine.

### Installation

1. Clone the repository:
    ```sh
    git clone <repository-url>
    ```
2. Navigate to the project directory:
    ```sh
    cd UserAggregator
    ```

### Running the Application

1. Build the project:
    ```sh
    dotnet build
    ```
2. Run the project:
    ```sh
    dotnet run
    ```
3. Follow the prompts to enter the folder path and desired file format (json/csv).

### Project Structure
