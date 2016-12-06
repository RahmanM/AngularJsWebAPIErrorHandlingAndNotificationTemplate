using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Weather.Data;
using Weather.Repositories;

namespace Weather.Api
{
    public class CitiesController : ApiController
    {
        private ICitiesRepository CitiesRepository { get; set; }

        #region Default Constructor and DI

        public CitiesController(ICitiesRepository citiesRepository)
        {
            CitiesRepository = citiesRepository;
        }

        #endregion
        
        #region Main Actions

        /// <summary>
        /// Get list of cities for a given country
        /// </summary>
        /// <param name="countryName">Country name</param>
        [Route("api/Cities/GetCitiesByCountryName/{countryName:alpha}")]
        public IHttpActionResult GetCitiesByCountryName(string countryName)
        {
            var cities =
                CitiesRepository.GetCitiesByCountryName(countryName);

            return Ok(cities);
        }

        /// <summary>
        /// Get weather information for a city
        /// </summary>
        /// <param name="id">Id of the city to get informatin for</param>
        [ResponseType(typeof (City))]
        public IHttpActionResult GetCity(int id)
        {
            //City city = db.Cities.Find(id);
            var city = CitiesRepository.GetCity(id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        #endregion

    }
}