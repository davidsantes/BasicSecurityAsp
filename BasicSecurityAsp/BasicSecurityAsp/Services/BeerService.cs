using BasicSecurityAsp.Models;
using System.Reflection;
using System.Text.Json;

namespace BasicSecurityAsp.Services
{
    public class BeerService : IBeerService
    {
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\beers.json");
        public async Task<List<Beer>> Get()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers = JsonSerializer.Deserialize<List<Beer>>(content);
            return beers;
        }
    }
}
