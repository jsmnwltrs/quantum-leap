using Microsoft.AspNetCore.Mvc;
using QuantumLeap.Data;

namespace QuantumLeap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeapersController : ControllerBase
    {
        readonly LeapersRepository _leapersRepository;

        public LeapersController()
        {
            _leapersRepository = new LeapersRepository();
        }

        [HttpGet("allleapers")]
        public ActionResult GetLeapers()
        {
            var leapers = _leapersRepository.GetAllLeapers();

            return Ok(leapers);
        }
    }
}