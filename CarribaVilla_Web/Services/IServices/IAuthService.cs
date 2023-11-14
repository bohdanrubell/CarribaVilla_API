using CarribaVilla_Web.Models.Dto;

namespace CarribaVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegistrationRequestDTO objToCreate);
        Task<T> LogoutAsync<T> (TokenDTO obj);
    }
}
