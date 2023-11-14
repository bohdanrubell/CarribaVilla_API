using CarribaVilla_Web.Models;

namespace CarribaVilla_Web.Services.IServices
{
    public interface IApiMessageRequestBuilder
    {
        HttpRequestMessage Build (APIRequest apiRequest);
    }
}
