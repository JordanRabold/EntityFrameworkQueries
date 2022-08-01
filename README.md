# Entity Framework Queries

## Getting Started 
- VS 2022
- .NET 6
- AP Database Installed

You may need to change the DB connection string located in the APcontext class
By default it points to mssqllocaldb. If your AP script is not installed on 
mssqllocaldb, update the string
```csharp
 optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocalDb; Initial Catalog=AP");
 ```
