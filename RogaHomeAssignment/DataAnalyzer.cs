
using System.Drawing;
/// <summary>
/// The DataAnalyzer class is responsible for loading and analyzing data from a CSV file.
/// </summary>
namespace RogaHomeAssignment
{

    public class DataAnalyzer
    {
        private readonly List<Person> people;
        /// <summary>
        /// Initializes a new instance of the DataAnalyzer class.
        /// </summary>
        /// <param name="filePath">The file path of the CSV file to be analyzed.</param>
        public DataAnalyzer(string filePath)
        {
            people = new List<Person>();
            try
            {
                LoadData(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads data from the specified CSV file into the people list.
        /// </summary>
        /// <param name="filePath">The file path of the CSV file to be loaded.</param>
        private void LoadData(string filePath)
        {
            try
            {
                using var reader = new StreamReader(filePath);
                // Skip header line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line?.Split(',');

                    try
                    {
                        var person = new Person
                        {
                            FirstName = values?[0],
                            LastName = values?[1],
                            Age = int.Parse(values[2]),
                            Weight = int.Parse(values[3]),
                            Gender = (Gender)Enum.Parse(typeof(Gender), values[4])

                        };

                        people.Add(person);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine($"Data format error: {fe.Message}");
                    }
                    catch (IndexOutOfRangeException ie)
                    {
                        Console.WriteLine($"Data parsing error: {ie.Message}");
                    }
                }
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine($"File not found: {fnfe.Message}");
                throw; // Re-throwing to indicate that the file was not found
            }
            catch (IOException ioe)
            {
                Console.WriteLine($"IO error: {ioe.Message}");
                throw; // Re-throwing to indicate an IO error
            }
        }

        /// <summary>
        /// Calculates the average age of all people in the list.
        /// </summary>
        /// <returns>The average age as a double.</returns>
        public double CalculateAverageAge()
        {
            return people.Average(p => p.Age);
        }
        /// <summary>
        /// Counts the number of people within a specified weight range.
        /// </summary>
        /// <param name="lowerBound">The lower bound of the weight range.</param>
        /// <param name="upperBound">The upper bound of the weight range.</param>
        /// <returns>The count of people within the weight range.</returns>
        public int CountPeopleInWeightRange(int lowerBound, int upperBound)
        {
            return people.Count(p => p.Weight >= lowerBound && p.Weight <= upperBound);
        }
        /// <summary>
        /// Calculates the average age of people within a specified weight range.
        /// </summary>
        /// <param name="lowerBound">The lower bound of the weight range.</param>
        /// <param name="upperBound">The upper bound of the weight range.</param>
        /// <returns>The average age of people within the weight range as a double.</returns>
        public double CalculateAverageAgeInWeightRange(int lowerBound, int upperBound)
        {
            var filteredPeople = people.Where(p => p.Weight >= lowerBound && p.Weight <= upperBound).ToList();
            return filteredPeople.Any() ? filteredPeople.Average(p => p.Age) : 0;
        }
    }
}