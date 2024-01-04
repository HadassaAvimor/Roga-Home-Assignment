# Roga-Home-Assignment
Home assignment for Roga company.

## Introduction
This project consists of a simple C# console application that performs data analysis on a dataset of individuals. The dataset includes information such as first name, last name, age, weight, and gender. The application calculates the average age of all individuals, counts the number of people within a certain weight range, and calculates the average age of people within that weight range.

## Project Structure
```bash
RogaHomeAssignment/
│
├── DataAnalyzer.cs     # Main class responsible for analyzing the data.
│
├── GlobalUsing.cs      # Contains global using directives for the project.
│
├── Program.cs          # Entry point of the application. Initializes and runs the data analysis.
│
├── Data/               # Directory for data files.
│   └── people_dataset.csv  # CSV file containing the dataset to be analyzed.
│
└── DTO/                # Directory for Data Transfer Objects (DTOs).
    ├── Gender.cs       # Enum defining the gender types.
    └── Person.cs       # Class representing a person with properties like name, age, weight, etc.
```
