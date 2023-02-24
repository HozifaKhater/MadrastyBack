using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  MadrastyAPI.Models;
using  Microsoft.AspNetCore.Mvc;
using  System.Data;


namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class school_partyController : ControllerBase
    {
        private readonly ISchool_partyService _service;
        public school_partyController(ISchool_partyService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> save_in_school_party(School_party school_party)
        {
            var result = await _service.save_in_school_party(school_party);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_school_party()
        {
            var result = await _service.get_school_party();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_school_party_with_id(int id)
        {
            var result = await _service.get_school_party_with_id(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> update_school_party(School_party school_party)
        {
            var result = await _service.update_school_party(school_party);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_school_party(int id)
        {


            var result = await _service.delete_from_school_party(id);

            return Ok(result);
        }
    }
}
