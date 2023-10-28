using CarribaVilla_ASP_API.Models;

namespace CarribaVilla_ASP_API.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
