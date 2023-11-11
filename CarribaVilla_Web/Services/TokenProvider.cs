﻿using CarribaVilla_Utility;
using CarribaVilla_Web.Models.Dto;
using CarribaVilla_Web.Services.IServices;

namespace CarribaVilla_Web.Services
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.AccessToken);
        }
        public TokenDTO GetToken()
        {
            try
            {
                bool hasAccessToken = _contextAccessor.HttpContext.Request.Cookies.TryGetValue(SD.AccessToken, out string accessToken);
                TokenDTO tokenDTO = new()
                {
                    AccessToken = accessToken
                };
                return hasAccessToken ? tokenDTO : null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void SetToken(TokenDTO tokenDTO)
        {
            var cookieOptions = new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(60) };
            _contextAccessor.HttpContext.Response.Cookies.Append(SD.AccessToken, tokenDTO.AccessToken, cookieOptions);
        }
    }
}