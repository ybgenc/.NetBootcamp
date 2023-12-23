//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Cryptography.X509Certificates;

//namespace netBootcamp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CountryController : ControllerBase
//    {
//        [HttpGet]
//        public string[] GetCountry()
//        {
//            string[] countries = new string[]
//            {
//                "United States",
//                "Canada",
//                "United Kingdom",
//                "Germany",
//                "France",
//                "Italy",
//                "Japan",
//                "Australia",
//                "Brazil",
//                "India",
//                "China",
//                "South Korea",
//                "Mexico",
//                "Russia",
//                "South Africa",
//                "Argentina",
//                "Spain",
//                "Netherlands",
//                "Sweden",
//                "Switzerland"
//            };

//            return countries;
//        }

//        [HttpGet("{userinput}")]
//        public string[] getCounryThatMuch(int userinput)
//        {
//            string[] totalcountry = new string[]
//            {
//                "united states",
//                "canada",
//                "united kingdom",
//                "germany",
//                "france",
//                "italy",
//                "japan",
//                "australia",
//                "brazil",
//                "india",
//                "china",
//                "south korea",
//                "mexico",
//                "russia",
//                "south africa",
//                "argentina",
//                "spain",
//                "netherlands",
//                "sweden",
//                "switzerland"
//            };
//            if (userinput < 0 || userinput > totalcountry.length)
//            {

//                return new string[] { "invalid number" };
//            }
//            else
//            {
//                return totalcountry.takelast(userinput).toarray();
//            }
//        }


//        // Same Country That Much
//        //
//        //[HttpGet("{userInput2}")]
//        //public string[] SameCountryThatMuch(int userInput2)
//        //{
//        //    string[] country = new string[]
//        //    {
//        //        "United States",
//        //        "Canada",
//        //        "United Kingdom",
//        //        "Germany",
//        //        "France",
//        //        "Italy",
//        //        "Japan",
//        //        "Australia",
//        //        "Brazil",
//        //        "India",
//        //        "China",
//        //        "South Korea",
//        //        "Mexico",
//        //        "Russia",
//        //        "South Africa",
//        //        "Argentina",
//        //        "Spain",
//        //        "Netherlands",
//        //        "Sweden",
//        //        "Switzerland"

//        //    };
//        //    if (userInput2 <= 0 || userInput2 > country.Length)
//        //    {
//        //        return new string[] { "Invalid number" };
//        //    }
//        //    else
//        //    {
//        //        var selected = country.ElementAt(userInput2 - 1);
//        //        var output = new string[userInput2];

//        //        for (int i = 0; i < userInput2; i++)
//        //        {
//        //            output[i] = selected;
//        //        }

//        //        return output;
//        //    }

//        //}

//    }
//}
