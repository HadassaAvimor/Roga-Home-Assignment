using RogaHomeAssignment;
string FILE_PATH = "../../../Data/people_dataset.csv";

try
{
    // Build the csv file.
    CSVDataGenerator.GenerateAndSaveCSV(FILE_PATH, 1000);

    // Create an instance of DataAnalyzer
    DataAnalyzer analyzer = new(FILE_PATH);

    // Calculate and display the average age of all people
    try
    {
        double averageAge = analyzer.CalculateAverageAge();
        Console.WriteLine($"Average Age of All People: {averageAge:F2}");
    }
    catch (InvalidOperationException ioe)
    {
        Console.WriteLine($"Error calculating average age: {ioe.Message}");
    }

    // Count and display the number of people weighing between 120lbs and 140lbs
    try
    {
        int countInWeightRange = analyzer.CountPeopleInWeightRange(120, 140);
        Console.WriteLine($"Number of People Weighing Between 120lbs and 140lbs: {countInWeightRange}");
    }
    catch (InvalidOperationException ioe)
    {
        Console.WriteLine($"Error counting people in weight range: {ioe.Message}");
    }

    // Calculate and display the average age of people weighing between 120lbs and 140lbs
    try
    {
        double averageAgeInWeightRange = analyzer.CalculateAverageAgeInWeightRange(120, 140);
        Console.WriteLine($"Average Age of People Weighing Between 120lbs and 140lbs: {averageAgeInWeightRange:F2}");
    }
    catch (InvalidOperationException ioe)
    {
        Console.WriteLine($"Error calculating average age in weight range: {ioe.Message}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();