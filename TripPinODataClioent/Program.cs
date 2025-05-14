using Microsoft.OData.SampleService.Models.TripPin;
namespace TripPinODataClioent
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            await Program.ListPeople();
        }
        static async Task ListPeople()
        {
            var serviceRoot = "https://services.odata.org/V4/TripPinServiceRW/";
            var context = new DefaultContainer(new Uri(serviceRoot));

            IEnumerable<Person> people = await context.People.ExecuteAsync();
            foreach (var person in people)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }
    }
}
