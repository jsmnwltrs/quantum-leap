using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantumLeap.Data;

namespace QuantumLeap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeapeesController : ControllerBase
    {
            readonly LeapeesRepository _leapeesRepository;

            public LeapeesController()
            {
                _leapeesRepository = new LeapeesRepository();
            }

            [HttpGet("allleapees")]
            public ActionResult GetLeapees()
            {
                var leapees = _leapeesRepository.GetAllLeapees();

                return Ok(leapees);
            }
        }
}