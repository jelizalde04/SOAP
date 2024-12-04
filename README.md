# SOAP Service Example

This project demonstrates how to create and host a simple SOAP web service using .NET 6 (or later).

## Overview

The example shows how to implement a basic SOAP service in .NET, which exposes a service contract with simple operations.

## Prerequisites

- .NET 6 or later
- Visual Studio or Visual Studio Code (optional, for development)

## Getting Started

Follow these steps to get the project up and running on your local machine.

### 1. Clone the Repository

Clone this repository to your local machine:

    git clone https://github.com/jelizalde04/SOAP.git
    cd SoapServiceExample

### 2. Install Dependencies
Restore the project dependencies with the following command:

        dotnet restore

### 3. Run the Service
Run the SOAP service:

    dotnet run
    
The service will now be hosted locally, and you can test it using SOAP requests.

### 4. Accessing the Service
Once the service is running, it should be accessible on http://localhost:5000 (or another port, if configured differently).

Installing WCF Packages
In case the required WCF packages are not included, you can install them by running:

        dotnet add package System.ServiceModel.Http
        dotnet add package System.ServiceModel.Primitives
