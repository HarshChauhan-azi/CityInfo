using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync(int cityId);
        Task<bool> CityExistsAsync(int cityId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cityId"></param>
        /// <param name="pointOfInterestId"></param>
        /// <returns></returns>
        Task<PointOfInterest> GetPointsOfInterestAsync(int cityId, int pointOfInterestId);
        Task<PointOfInterest> GetPointsOfInterestForCityAsync(int cityId);
        Task<PointOfInterest> GetPointsOfInterestForCityAsync(int cityId, int pointOfInterestId);
    }
}
