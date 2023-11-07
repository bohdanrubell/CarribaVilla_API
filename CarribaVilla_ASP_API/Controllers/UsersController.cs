using CarribaVilla_ASP_API.Models;
using CarribaVilla_ASP_API.Models.Dto;
using CarribaVilla_ASP_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CarribaVilla_ASP_API.Controllers
{
    [Route("api/v{version:apiVersion}/UsersAuth")]
    [ApiController]
    [ApiVersionNeutral]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        protected APIResponse _responce;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _responce = new();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
        {
            var loginResponse = await _userRepository.Login(model);
            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                _responce.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _responce.IsSuccess = false;
                _responce.ErrorMessages.Add("Username or password is incorrect!");
                return BadRequest(_responce);
            }
            _responce.StatusCode = System.Net.HttpStatusCode.OK;
            _responce.IsSuccess = true;
            _responce.Result = loginResponse;
            return Ok(_responce);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO model)
        {
            bool ifUserNameUnique = _userRepository.IsUniqueUser(model.UserName);
            if (!ifUserNameUnique)
            {
                _responce.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _responce.IsSuccess = false;
                _responce.ErrorMessages.Add("Username already exists!");
                return BadRequest(_responce);
            }

            var user = await _userRepository.Register(model);
            if (user == null)
            {
                _responce.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _responce.IsSuccess = false;
                _responce.ErrorMessages.Add("Error while registering!");
                return BadRequest(_responce);
            }
            _responce.StatusCode = System.Net.HttpStatusCode.OK;
            _responce.IsSuccess = true;
            return Ok(_responce);
        }
    }
}
