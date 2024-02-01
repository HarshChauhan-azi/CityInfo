using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() {
            Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name  = "New York City",
                Description = "Loremasdbkfjbsd",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Central Park",
                        Description = "asdfbhbfsfnksf"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Central zoo",
                        Description = "asasfdfbhbfsfnksf"
                    },
                }
            },
            new CityDto() {
            Id = 2,
            Name = "London",
            Description = "sbdfbsbdfsdf",
            PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 3,
                        Name = "Central Aqua",
                        Description = "asdfbhbfsfnksf"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 4,
                        Name = "Adven zoo",
                        Description = "asasfdfbhbfsfnksf"
                    },
                }
            },
            new CityDto() {
            Id = 3,
            Name = "Lisbon",
            Description = "asdfgfb",
            PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 5,
                        Name = "Central Park",
                        Description = "asdfbhbfsfnksf"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 6,
                        Name = "Central zoo",
                        Description = "asasfdfbhbfsfnksf"
                    },
                }
            },
            new CityDto() {
            Id = 4,
            Name = "Giza",
            Description = "bgwsdfsdf",
            PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 7,
                        Name = "Central Park",
                        Description = "asdfbhbfsfnksf"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 8,
                        Name = "Central zoo",
                        Description = "asasfdfbhbfsfnksf"
                    },
                }
            }

        };
        }
    }
}
