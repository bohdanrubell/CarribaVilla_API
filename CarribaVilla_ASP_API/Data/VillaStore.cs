using CarribaVilla_ASP_API.Models.Dto;

namespace CarribaVilla_ASP_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id= 1, Name = "Pool View", Sqft = 100, Occupancy= 4},
                new VillaDTO { Id= 2, Name = "Beach View", Sqft = 150, Occupancy= 3}
            };
    }
}
