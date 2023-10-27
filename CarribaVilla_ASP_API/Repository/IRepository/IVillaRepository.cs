using CarribaVilla_ASP_API.Models;
using System.Linq.Expressions;

namespace CarribaVilla_ASP_API.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);   
    }
}
