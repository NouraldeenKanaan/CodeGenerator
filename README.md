Code Generator

Overview Code Generator is a C# application designed to automatically
generate business layer and data access layer classes for database
tables. It produces complete CRUD operations, creating standardized
classes that implement data manipulation functionality using
parameterized queries.

Project Structure The solution consists of the following components:

-   CodeGenerator: The main project containing the code generation
    application.

-   GeneratorLogic: A class library that provides the core functionality
    for generating business and data access layer classes. It includes
    the following key classes:

    -   clsColumn: Represents database column metadata, including name,
        data type, nullability, and primary key designation.

    -   clsGenerateBusinessLogicLayer: Responsible for generating
        business layer classes with properties, constructors, and CRUD
        methods including Save, FindByID, Delete, and GetAll.

    -   clsGenerateDataAccessLayer: Responsible for generating data
        access layer classes containing parameterized SQL operations for
        Create, Read, Update, Delete, and FindByID.

    -   clsUtil: Provides utility methods for generating parameter
        lists, SQL command parameters, and handling null values during
        code generation.
