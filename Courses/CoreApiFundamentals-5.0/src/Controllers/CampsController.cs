using CoreCodeCamp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : ControllerBase
    { 
        private readonly ICampRepository _repository;
        private readonly IMapper _mapper;

        public CampsController(ICampRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet] //atribute
        public async Task<ActionResult<CampModel[]>> Get()
        {
            try
            {
                var results = await _repository.GetAllCampsAsync();

                return _mapper.Map<CampModel[]>(results);
            }
            catch (Exception)
            {                           
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failrue");
            }

            //if (false) return BadRequest("Bad staff happens");
            // return Ok(new { Moniker = "ATL2018", Name = "Atlanta Code Camp" });

       

        }
    }
}
