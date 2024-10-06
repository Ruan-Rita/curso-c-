.NET Study Project
This project is part of my journey to learn and apply the fundamentals of the .NET framework and C#. It is designed as a hands-on study exercise, focusing on understanding key concepts such as MVC architecture and adding an additional service layer for separation of concerns.

Project Overview
The project demonstrates:

The basics of C# programming.
ASP.NET Core MVC (Model-View-Controller) architecture.
Implementing a service layer for handling business logic.
Applying dependency injection in controllers.
Building a simple REST API.
Key Concepts
Model-View-Controller (MVC): This project uses the MVC architecture to separate the responsibilities of data handling (Model), user interface (View), and application logic (Controller).
Service Layer: I introduced an additional layer for managing business logic, which makes the controllers more lightweight and focused on request handling.
Dependency Injection: Services are injected into the controllers, following the dependency inversion principle, improving testability and modularity.
Routing & HTTP Methods: The project demonstrates the use of various HTTP methods such as GET, POST, PUT, and DELETE in building APIs.
Technologies
ASP.NET Core - A modern web framework for building web apps and APIs.
C# - The main programming language used for this project.
Swagger - Integrated for API documentation and testing.
Entity Framework Core (planned for future use) - For database access.
How to Run
Clone the repository:

bash
Copiar código
git clone https://github.com/Ruan-Rita/curso-dotnet-5
Navigate to the project directory:

bash
Copiar código
cd dotnet-study-project
Build the project:

bash
Copiar código
dotnet build
Run the application:

bash
Copiar código
dotnet run
The API should now be available at https://localhost:5030/api (or as configured).

API Endpoints
GET /person - Fetches a list of persons.
GET /person/{id} - Fetches details of a specific person by ID.
POST /person - Adds a new person.
PUT /person - Updates a person.
DELETE /person/{id} - Deletes a person by ID.
Future Improvements
Implement Entity Framework for database interactions.
Enhance error handling and add logging.
Add unit tests to improve code reliability.
Learning Goals
Deepen understanding of C# and .NET ecosystem.
Master MVC architecture and how to extend it with additional layers.
Build a solid foundation for developing full-stack applications using .NET.