# ReserveRoom
A Hotel Reservation Application to practice C# WPF and MVVM
# ReserveRoom - WPF Application (MVVM)

## Table of Contents
- Introduction
- Features
- Technologies Used
- Getting Started
- Project Structure
- MVVM Design Pattern
- Room Reservation Process

## Introduction
ReserveRoom is a Windows Presentation Foundation (WPF) application developed using the Model-View-ViewModel (MVVM) design pattern. This application serves as a practice project for WPF and MVVM, simulating a room reservation system in a hotel. It allows users to reserve available rooms and provides basic features like viewing available rooms, managing reservations, and providing room details.

The application emphasizes separating concerns between the UI and business logic using the MVVM pattern, which makes it more modular, testable, and maintainable.

## Features
- View a list of available rooms
- Reserve a room for a selected date range
- Manage and view existing reservations
- Basic room details (room type, price, availability)

## Technologies Used
- **C#**
- **WPF (Windows Presentation Foundation)**
- **MVVM (Model-View-ViewModel)** design pattern
- **.NET Framework/ Core**

## Getting Started
To get a local copy of the project and run it on your machine:

1. Clone the repository:
    ```
    git clone https://github.com/yourusername/ReserveRoom.git
    ```

2. Open the solution in Visual Studio.

3. Restore NuGet packages if necessary.

4. Build the project:
    ```
    Build > Build Solution
    ```

5. Run the application:
    ```
    Debug > Start Debugging (F5)
    ```

## Project Structure
The project is structured according to the MVVM pattern:

- **Model**: Represents the data and business logic (e.g., Room, Reservation classes).
- **View**: The UI layer built using XAML, representing what the user interacts with.
- **ViewModel**: Acts as a bridge between the Model and View. It contains commands, properties, and the logic that binds the Model and View together.

### Key Directories (WIP):
- **/Models**: Contains the business logic and data (Room, Reservation, etc.)
- **/ViewModels**: Contains the ViewModel classes (MainViewModel, RoomViewModel, etc.)
- **/Views**: XAML views representing the user interface (MainWindow.xaml, RoomView.xaml, etc.)
- **/Commands**: Houses command classes to handle UI interactions (RelayCommand, etc.)

## MVVM Design Pattern
The MVVM pattern divides the project into three main components:

- **Model**: Handles the core data and business rules of the application (e.g., Room, Reservation).
- **View**: Defines the visual representation of data and user interface (UI) (XAML files).
- **ViewModel**: Contains logic that binds data between the Model and View. It handles user input and commands.

This separation of concerns ensures that each component of the application is loosely coupled and easier to maintain and test.

## Room Reservation Process (WIP)
1. The user can view available rooms.
2. After selecting a room, the user can input check-in and check-out dates.
3. Upon confirmation, the reservation is saved, and the room is marked as reserved.
4. Users can view and manage their current reservations.


