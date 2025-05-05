using LocationFinder.Services;

namespace LocationFinder
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var locationService = new LocationService();

            try
            {
                Console.WriteLine("Enter location:");               
                var locationQuery = Console.ReadLine();
                var result = await locationService.FindLocationAsync(locationQuery);

                Console.WriteLine($"Latitude: {result.Lat}, Longitude: {result.Lon}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
