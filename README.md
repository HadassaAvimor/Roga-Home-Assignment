# Roga-Home-Assignment
Home assignment for Roga company.

## Introduction
This project is a C# console application that not only performs data analysis on a dataset of individuals but also includes functionality for generating this dataset. It utilizes the Faker.Net library to create a diverse set of random data, including first names, last names, ages, weights, and genders. The dataset is then saved as a CSV file. The application analyzes this data to calculate the average age of all individuals, count the number of people within a specific weight range, and calculate the average age of people within that weight range.
## Project Structure
```bash
RogaHomeAssignment/
│
├── CSVDataGenerator.cs # Class responsible for generating and saving random data to a CSV file.
│
├── DataAnalyzer.cs     # Main class responsible for analyzing the data.
│
├── GlobalUsing.cs      # Contains global using directives for the project.
│
├── Program.cs          # Entry point of the application. Initializes the data generation and analysis.
│
├── Data/               # Directory for data files.
│   └── people_dataset.csv  # CSV file containing the dataset to be analyzed.
│
└── DTO/                # Directory for Data Transfer Objects (DTOs).
    ├── Gender.cs       # Enum defining the gender types.
    └── Person.cs       # Class representing a person with properties like name, age, weight, etc.
```
