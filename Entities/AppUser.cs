using System;

namespace DatingApp.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public required string UserName { get; set; }
    }
}

// public - access modifier

/*
Types of access modifiers:
public - accessible to all
private - accessible only to the class that contains it
protected - accessible only to the class that contains it and its derived classes
internal - accessible only to the current assembly  

C# is a case sensitive language.

public string? UserName { get; set; } -- ? means that this property can be null
public required string UserName { get; set; } -- required means that this property must be assigned a value

<Nullable>enable</Nullable> -- when this is set as enable, the compiler will allow the use of nullable reference types . We need to provide required or ? to property then
if we dont want this then we need to set <Nullable>disabled</Nullable> in DatingApp.csproj file.

Entity framework - ORM (Object Relational Mapping) is a way to map objects to tables in a relational database. It provides a set of classes and attributes that define the mapping between the objects and the database tables. Translate our code into SQL commands that update, insert, and delete data in the database.

Entity Framework Features:
1. Querying - converting linq to sql script
2. Change tracking - tracking changes to entities
3. Saving - saving changes to entities
4. Concurrency - handling concurrent updates to entities
5. Transactions - managing transactions
6. Caching - caching data (So when repeatedly querying the same data, it will be retrieved from the cache instead of the database)
7. Build-in conventions - built-in conventions for mapping entities to tables
8. configuration - configuration of the entity framework
9. Migrations - managing database schema changes

Id - itself says it a primary key. It is a unique identifier for each row in the table. It is used to identify the row in the table.
But if i want to make something like IdCheck and above that i need to mention 
[Key]
public int IdCheck { get; set; }

In development mode, settings are read from the appsettings.Development.json file. In production , testing and staging mode, settings are read from the appsettings.json file.

Git ignore files - when we use any compilier then some dll files are generated. So we need to add those files to .gitignore file.
*/
