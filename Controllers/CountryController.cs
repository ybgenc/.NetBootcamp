using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace netBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public string[] GetCountry()
        {
            string[] countries = new string[]
            {
                "United States",
                "Canada",
                "United Kingdom",
                "Germany",
                "France",
                "Italy",
                "Japan",
                "Australia",
                "Brazil",
                "India",
                "China",
                "South Korea",
                "Mexico",
                "Russia",
                "South Africa",
                "Argentina",
                "Spain",
                "Netherlands",
                "Sweden",
                "Switzerland"
            };

            return countries;
        }
        [HttpGet("{userInput}")]
        public string[] GetCounryThatMuch(int userInput)
        {
            string[] totalCountry = new string[]
            {
                "United States",
                "Canada",
                "United Kingdom",
                "Germany",
                "France",
                "Italy",
                "Japan",
                "Australia",
                "Brazil",
                "India",
                "China",
                "South Korea",
                "Mexico",
                "Russia",
                "South Africa",
                "Argentina",
                "Spain",
                "Netherlands",
                "Sweden",
                "Switzerland"
            };
            if (userInput < 0 || userInput > totalCountry.Length)
            {

                return new string[] { "Invalid number" };
            }
            else
            {
                return totalCountry.TakeLast(userInput).ToArray();
            }
        }

    }
}
