**Principles of Programming Demonstrated in task_1**

***DRY (Don't Repeat Yourself)*** The codebase adheres to the DRY principle by avoiding duplication of code. For example, in the Money class, the method SetAmount() is used to set the amount of money, which avoids repeating the assignment logic.Relevant code: [Money.cs - Line 42](./Money.cs#L42)


***KISS (Keep It Simple, Stupid)*** The code maintains simplicity by focusing on straightforward solutions without unnecessary complexity. For instance, the Money class has simple methods for setting and printing the amount, keeping the logic concise.Relevant code: [Money.cs](./Money.cs)


***SOLID Principles***
> *Single Responsibility Principle (SRP):* Each class has a single responsibility. For instance, the Reporting class handles reporting tasks, while the Warehouse class manages warehouse-related operations.Relevant code: [Reporting.cs](./Reporting.cs), [Warehouse.cs](./Warehouse.cs)

> *Open/Closed Principle (OCP):* The code is open for extension but closed for modification. For example, new functionalities can be added by extending existing classes without altering their core implementation.

> *Liskov Substitution Principle (LSP):* Derived classes can be substituted for their base classes without affecting the functionality. In this code, subclasses of Product can be used interchangeably.

> *Interface Segregation Principle (ISP):* Interfaces are specific to the needs of the clients. There are no unnecessary methods in interfaces. Although interfaces are not explicitly used in this code, the principle is demonstrated through the use of cohesive class structures.

> *Dependency Inversion Principle (DIP):* High-level modules do not depend on low-level modules; both depend on abstractions. In this code, Reporting depends on abstractions (e.g., Product, Warehouse) rather than concrete implementations.

***YAGNI (You Aren't Gonna Need It)*** The codebase follows the YAGNI principle by avoiding speculative features. It implements only the functionalities required for the current scope, without adding unnecessary complexity.

***Composition Over Inheritance*** The code favors composition over inheritance. For example, the Warehouse class contains a List<Product> to manage its products, rather than inheriting from a Product class.Relevant code: [Warehouse.cs - Line 28](./Warehouse.cs#L28)

***Program to Interfaces not Implementations*** The codebase programs to interfaces rather than concrete implementations. For instance, the Reporting class depends on the Warehouse interface, enabling flexibility in implementing different warehouse functionalities.Relevant code: [Reporting.cs - Line 25](./Reporting.cs#L25)

***Fail Fast*** The code follows the fail-fast principle by detecting and reporting errors as soon as they occur. For instance, when attempting to remove a product from the warehouse that is not present, an exception would be thrown.Relevant code: [Warehouse.cs - Line 38](./Warehouse.cs#L38)

*These principles collectively contribute to the code's readability, maintainability, and scalability. Each principle is demonstrated through specific examples within the codebase.*
