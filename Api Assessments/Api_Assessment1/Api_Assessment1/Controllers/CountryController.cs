using Api_Assessment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Assessment1.Controllers
{
    public class CountryController : ApiController
    {
     


         private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, Country_Name = "India", Capital = "Delhi" },
            new Country { ID = 2, Country_Name = "Pakistan", Capital = "Islamabad" },
            new Country { ID = 3, Country_Name = "Nepal", Capital = "Kathmandu" },
          
        };


        [HttpGet]
        [Route("get")]
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        [Route("byID")]
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST api/country
        [HttpPost]
        
        public List<Country> PostAll([FromBody] Country country)
        {
            countries.Add(country);
            return countries;
        }


        [HttpPut]
     
        public IEnumerable<Country> Put(int Cid, [FromUri] Country c)
        {
            countries[Cid - 1] = c;
            return countries;
        }


       

        [HttpDelete]
        [Route("Delete")]
        public IEnumerable<Country> Delete(int cid)
        {
            countries.RemoveAt(cid - 1);
            return countries;
        }
    }
}

