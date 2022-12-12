using MVC_Klas.Models;
using System.Text.Json;

namespace MVC_Klas.Services
{
    public class JsonFamilieService
    {

        public JsonFamilieService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonDataFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Families.json");
            }
        }


        public IEnumerable<Familie> GetFamilies()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonDataFileName))
            {
                Familie[] Lijst;
                Lijst = JsonSerializer.Deserialize<Familie[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return Lijst;
            }
        }

        public Familie GetFamilieByName(string name)
        {
            List<Familie> lijst = GetFamilies().ToList();
            return lijst.First(e => e.Naam == name);

        }

    }
}
