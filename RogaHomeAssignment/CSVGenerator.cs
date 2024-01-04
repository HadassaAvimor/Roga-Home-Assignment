/// <summary>
/// The CSVDataGenerator is responsible for generating a csv file with random data.
/// </summary>
namespace RogaHomeAssignment
{
   
    public static class CSVDataGenerator

    {
        /// <summary>
        /// Validates the person object.
        /// </summary>
        /// <param name="person">Person object to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        private static bool IsValidPerson(Person person)
        {
            // Here you can add any validation logic you deem necessary
            return person.Age >= 18 && person.Age <= 70 && person.Weight >= 100 && person.Weight <= 250;
        }
        /// <summary>
        /// Generates a CSV file with random people data.
        /// </summary>
        /// <param name="filePath">Path where the CSV file will be saved.</param>
        /// <param name="numberOfRecords">Number of records to generate.</param>
        public static void GenerateAndSaveCSV(string filePath, int numberOfRecords)
        {
            var random = new Random();

            try
            {
                using var writer = new StreamWriter(filePath, false, Encoding.UTF8);

                // Write the header
                writer.WriteLine("FirstName,LastName,Age,Weight,Gender");

                // Write the data
                for (int i = 0; i < numberOfRecords; i++)
                {
                    var person = new Person
                    {
                        FirstName = Faker.Name.First(),
                        LastName = Faker.Name.Last(),
                        Age = random.Next(18, 71),
                        Weight = random.Next(100, 251),
                        Gender = (Gender)random.Next(2)
                    };

                    // Validate data before writing
                    if (IsValidPerson(person))
                    {
                        writer.WriteLine($"{person.FirstName},{person.LastName},{person.Age},{person.Weight},{person.Gender}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while generating CSV: {ex.Message}");
            }
        }
    }
    }