# ASP.NET Core Web Application with SQL Server in Docker

This ASP.NET Core web application demonstrates how to integrate with a SQL Server database running inside a Docker container. It features basic CRUD operations using Entity Framework Core, showcasing a straightforward way to interact with database entities.

Getting Started

To get this project up and running on your local machine for development and testing purposes, you'll need to follow these steps. This guide also includes notes on deploying the project in a live environment.

## Prerequisites

#### Visual Studio 2019 or Later

  Download: Go to the Visual Studio website and download the installer for Visual Studio 2019 or later.
   Install: Run the installer, select the ASP.NET and web development workload, and click "Install".
   Launch: Open Visual Studio after installation.

#### Docker Desktop
Download: Visit Docker Hub to download Docker Desktop for your OS.
Install: Run the downloaded installer and follow the prompts.
Verify: Open a terminal or command prompt and type docker --version to ensure Docker is installed correctly.
These steps will prepare your development environment for creating ASP.NET Core applications with SQL Server in Docker.

## Installation

Follow these steps to set up your development environment:

  Clone the project repository to your local machine.
  Run a Docker container for SQL Server using the following command:

    

    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong(!)Password" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
  Make sure to replace YourStrong(!)Password with a secure password of your choosing.
  Open the solution in Visual Studio and restore all necessary NuGet packages.
  Update the database connection string in appsettings.json to match your SQL Server credentials and server name, typically localhost for development purposes.
  Start the application from Visual Studio to begin development and testing.

### Usage
The application is a single-page interface for managing a book database, offering the following key functionalities:
Viewing Books

  The main page displays a list of all books in the database, including details like title, author, and publication year.

Adding a New Book

   Click the "Add Book" button to open a form for entering the new book's details.
   Fill in the title, author, and publication year, then click "Save" or "Submit".
   The new book will appear on the main page, indicating it has been added to the database.

The application is designed for simplicity, allowing users to easily add and view books on a single page.
Development

To add new features to the application or modify existing ones, follow the standard development practices of coding, testing, and reviewing before merging changes into the main branch.

## I'm deeply grateful to Alla and Yael for entrusting me with this project. Their confidence in my abilities has been a great source of motivation. Thank you for this remarkable opportunity.
