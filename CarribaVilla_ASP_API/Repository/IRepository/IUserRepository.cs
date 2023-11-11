using CarribaVilla_ASP_API.Models;
using CarribaVilla_ASP_API.Models.Dto;

namespace CarribaVilla_ASP_API.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<TokenDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
