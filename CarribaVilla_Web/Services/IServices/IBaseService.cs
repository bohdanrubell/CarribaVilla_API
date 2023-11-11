using CarribaVilla_ASP_API.Models;
using CarribaVilla_Web.Models;

namespace CarribaVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; }

        Task<T> SendAsync<T>(APIRequest apiRequest, bool withBearer = true);
    }
}
