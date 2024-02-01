using AutoMapper;
using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;
        private ICityInfoRepository _cityInfoRepository;
        private readonly IMapper mapper;

        public CitiesController(ICityInfoRepository cityInfoRepository, IMapper mapper)
        {
            _cityInfoRepository = cityInfoRepository ?? throw new ArgumentNullException(nameof(cityInfoRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities()
        {
            var cityEntities = await _cityInfoRepository.GetCitiesAsync();
            var result = new List<CityWithoutPointsOfInterestDto>();
            return Ok(mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities));
            //foreach (var cityEntity in cityEntities)
            //{
            //    result.Add(new CityWithoutPointsOfInterestDto
            //    {
            //        Id = cityEntity.Id,
            //        Name = cityEntity.Name,
            //        Description = cityEntity.Description
            //    });
            //}
            //return Ok(result);
            //return Ok(_citiesDataStore.Cities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCity(int id, bool includePointsOfInterest = false)
        {
            var city = await _cityInfoRepository.GetCityAsync(id, includePointsOfInterest);
            if (city == null)
            {
                return NotFound();
            }
            if (includePointsOfInterest)
            {
                return Ok(mapper.Map<CityDto>(city));
            }
            return Ok(mapper.Map<CityWithoutPointsOfInterestDto>(city));
            //var cityToReturn = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);
            //if (cityToReturn == null)
            //{
            //    return NotFound();
            //}
            //return Ok();
            //return new JsonResult(CitiesDataStore.current.Cities.FirstOrDefault(c=>c.Id == id));
        }
    }
}
