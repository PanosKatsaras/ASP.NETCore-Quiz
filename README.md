# Quiz App

## Overview
This project is an ASP.NET Core application, with SQL Server Database Connection and CRUD Operations.

## Technologies Used
ASP.NET Core (.NET 6)

Microsoft SQL Server 2022

## Prerequisites
Before cloning the project, ensure you have the following installed:

Visual Studio or Visual Studio Code


.NET 6


Microsoft SQL Server 2022

## Getting Started
To run this project locally, follow these steps:


Clone this repository: git clone https://github.com/username/repository.git

Open the project in Visual Studio or Visual Studio Code.

Create a new file named appsettings.local.json (or any suitable name) in the project root.
This file will contain local configurations including the database connection string.

Open SQL Server Management Studio (SSMS) or use SQL Server Object Explorer in Visual Studio.

Connect to the LocalDB instance (usually (LocalDB)\MSSQLLocalDB).

Use the "Attach Database" option to create or attach a .mdf file to the LocalDB instance.

Open appsettings.local.json in a text editor.

Add the database connection string in JSON format.

Identify where the application reads the configuration settings.

Modify the code to load configurations from appsettings.local.json or use environment variables if applicable.

Build and run the ASP.NET project in Visual Studio or using command-line tools.

Ensure the application successfully connects to the local database specified in appsettings.local.json.

## Folder Structure

Controllers: Contains controllers for handling HTTP requests


Models: Data models used in the application


Views: Contains the UI components or views
