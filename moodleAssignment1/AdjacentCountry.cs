namespace AdjacentCountry
{
    internal class AppMain
    {
        static void Main(string[] args)
        {
            var countryList = new Dictionary<string, string[]>
            {
                {
                    "IN",
                    new string[]
                    {
                        "Pakistan",
                        "China",
                        "Nepal",
                        "Bhutan",
                        "Bangladesh",
                        "Myanmar",
                        "Sri Lanka",
                        "Maldives",
                    }
                },
                { "US", new string[] { "Canada", "Mexico", "Russia", "Cuba" } },
                { "NZ", new string[] { "Australia", "Fiji", "Tonga" } },
            };
            Console.WriteLine("Enter Name of Country (i.e IN/US/NZ )");
            string userInput = Console.ReadLine();

            if (countryList[userInput] != null)
            {
                foreach (var country in countryList[userInput])
                {
                    Console.Write(country + ", ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid country name");
            }
        }
    }
}
