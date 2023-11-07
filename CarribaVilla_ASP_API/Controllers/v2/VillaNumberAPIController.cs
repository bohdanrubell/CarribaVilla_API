using AutoMapper;
using CarribaVilla_ASP_API.Models.Dto;
using CarribaVilla_ASP_API.Models;
using CarribaVilla_ASP_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Authorization;
using System.Collections;

namespace CarribaVilla_ASP_API.Controllers
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController: ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            this._response = new();
            _dbVilla = dbVilla;
        }
        //[MapToApiVersion("2.0")]
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Bohdan", "Rubel" };
        }
    }
}
