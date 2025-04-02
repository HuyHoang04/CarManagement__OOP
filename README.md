# CarManagement__OOP

## Description

This project is an object-oriented (OOP) application for managing car rentals. It includes features for creating customer profiles, adding vehicles to the system, managing rental contracts, applying discounts, and collecting customer reviews. The application is built using C# and utilizes Windows Forms for the user interface.

## Features and Functionality

*   **Customer Management:**
    *   Create new customer profiles with details such as name, ID, date of birth, address, and phone number.
    *   Search for existing customers by ID.
*   **Vehicle Management:**
    *   Add different types of vehicles to the system, including Four Seats Cars, Motobikes, Practice Driving Cars, Tourist Cars, and Wedding Cars.
    *   Vehicle details include brand, buy year, kilometer reading, insurance, and type-specific attributes (e.g., spare tire for Four Seats Cars, toolbox for Motobikes).
*   **Rental Contract Management:**
    *   Create rental contracts for customers.
    *   Specify rental dates, duration, deposit amounts, and whether a driver is hired.
    *   Apply sale-off codes for discounts.
    *   Calculate rental prices based on vehicle type, rental duration, discounts, and additional costs (e.g., driver hire).
*   **Discount Management:**
    *   Add different types of discounts, such as holiday promotions, customer loyalty discounts, and seasonal price increases/decreases.
    *   Specify discount percentages and validity periods.
*   **Review Management:**
    *   Collect customer reviews for vehicles and the rental service.
    *   Reviews include title, content, rating, vehicle model, and rental experience.
*   **File I/O:**
    *   Write and read customer data to/from CSV files using the `FileHelper` class in `CarManagement/Utils/FileHelper.cs`.
    *   Write vehicle data to CSV files.

## Technology Stack

*   C# (.NET 7.0 & .NET Framework 4.8)
*   Windows Forms

## Prerequisites

*   .NET SDK 7.0 or later
*   .NET Framework 4.8
*   Visual Studio or another compatible IDE

## Installation Instructions

1.  Clone the repository:

    ```bash
    git clone https://github.com/HuyHoang04/CarManagement__OOP.git
    ```

2.  Navigate to the project directory:

    ```bash
    cd CarManagement__OOP
    ```

3.  Open the `WinFormsApp1.sln` solution file in Visual Studio.

## Usage Guide

1.  **Running the Application:**

    *   In Visual Studio, build and run the `WinFormsApp1` project. This will launch the main menu of the car rental management system.
    *   The `Menu.cs` file in `WinFormsApp1` provides the main menu.

2.  **Creating a New Customer Profile:**

    *   Click the "Customer" button in the main menu to launch the `Customerform` form.
    *   Navigate to the "New Register" tab.
    *   Enter the customer's details: name, ID, date of birth (in `dd/MM/yyyy` format), address, and phone number.
    *   Click the "Done" button to create the profile. The new customer will be added to the `RentalGuest.All` list.

3.  **Adding a Vehicle:**

    *   Click the "Owner" button in the main menu to launch the `ManagerForm` form.
    *   Navigate to the "Add Vehicle" tab.
    *   Select the car type from the `comboBox1` (Four Seats Car, Motobike, Practice Driving Car, Tourist Car, Wedding Car).
    *   Enter the vehicle's details: level, purpose, brand, buy year, kilometer reading, and insurance.
    *   Enter the type-specific data for the vehicle selected, and click done.
    *   Click the "Done" button to add the vehicle.  The new vehicle will be added to the `Vehicle.All` list.

4.  **Creating a Rental Contract:**

    *   In the `Customerform`, navigate to the "Rent Vehicle" tab.
    *   Enter the customer's ID in the "Customer ID" field to search a exist Customer for the Rental.
    *   Select the brand of the car to rent with the combobox (ex: Honda, Toyota,...)
    *   Enter the rental date in the "Day Rent" field in `dd/MM/yyyy` format.
    *   Enter the rental duration in days in the "Time Rent" field.
    *   Enter the deposit amount in the "Deposit" field.
    *   Select "Yes" or "No" from the "Hire Driver" dropdown.
    *   Select a sale-off code (if applicable) from the "Sale-off CODE" dropdown.
    *   Click the "Rent" button to create the contract.  The new contract will be added to the `Contract.All` list.

5.  **Adding a Sale Off:**

    *   In the `ManagerForm`, navigate to the "Sale Off" tab.
    *   Select the description (ex: Holiday, Customer Loyalty,...) with `DescriptionBox` combobox
    *   Enter the code tittle.
    *   Enter the start and end date.
    *   Enter the discount percentage in the "Discount Percentage" field.
    *   Click the "Done" button to create the discount.  The new sale off will be added to the `SaleOff.Sale` list.

6.  **Adding a Review:**

    *   In the `Customerform`, navigate to the "Review" tab.
    *   Enter the information need.
    *   Click the rate star button.
    *   Click the "Done" button to create the review.  The new review will be added to the `Review.All` list.

## API Documentation

N/A - This project does not expose an API.

## Contributing Guidelines

Contributions are welcome!  To contribute to this project, please follow these guidelines:

1.  Fork the repository.
2.  Create a new branch for your feature or bug fix.
3.  Make your changes and commit them with descriptive commit messages.
4.  Test your changes thoroughly.
5.  Submit a pull request to the `main` branch.

## License Information

This project does not currently have a specified license. All rights are reserved by the owner of the repository.

## Contact/Support Information

For questions or support, please contact [HuyHoang04](https://github.com/HuyHoang04) via GitHub.