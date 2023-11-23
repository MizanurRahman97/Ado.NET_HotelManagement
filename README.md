# HotelManagement

# Hotel Management System - ADO.NET Project

## Overview
This Hotel Management System is a .NET project that utilizes ADO.NET for database connectivity. It is designed to manage various aspects of a hotel, including guest reservations, room management, and billing.

## Features
- **Guest Management**: Keep track of guest information, including check-in and check-out dates.
- **Room Management**: Manage room availability, types, and assignments.
- **Reservation System**: Easily create, update, and cancel guest reservations.
- **Billing System**: Generate and manage bills for guest stays.
- **Reporting**: View and export reports on room occupancy, revenue, and other key metrics.
- **User Authentication**: Secure access with user roles (admin, staff, etc.).

## Technologies Used
- **C#**: The primary programming language for the application.
- **ADO.NET**: Used for database connectivity to interact with the underlying database.
- **SQL Server**: The database management system used to store and retrieve data.
- **Windows Forms**: GUI components for creating a desktop application.

## Setup Instructions
1. **Database Setup**:
    - Open SQL Server Management Studio.
    - Execute the SQL scripts in the `DatabaseScripts` folder to create the necessary tables and stored procedures.

2. **Connection String**:
    - Open the project in Visual Studio.
    - Locate the `app.config` file and update the connection string with your SQL Server details.

    ```xml
    <connectionStrings>
        <add name="HotelManagementConnectionString" connectionString="Data Source=YOUR_SERVER;Initial Catalog=HotelManagementDB;Integrated Security=True" providerName="System.Data.SqlClient" />
    </connectionStrings>
    ```

3. **Build and Run**:
    - Build and run the project in Visual Studio.

## Folder Structure
- **/DatabaseScripts**: Contains SQL scripts for creating the database and tables.
- **/Forms**: Windows Forms for different modules (Guest Management, Room Management, etc.).
- **/Models**: Data models used in the application.
- **/Repositories**: ADO.NET code for interacting with the database.
- **/Services**: Business logic and services.

## Contributors
- [Mizanur Rahman]

## License
This project is licensed under the [MIT License](LICENSE).

Feel free to contribute, report issues, or provide feedback!
