using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Http;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
        public class behaviours_statusController : ControllerBase
        {
            private readonly Ibehaviours_statusService _service;
            public behaviours_statusController(Ibehaviours_statusService service)
            {
                _service = service;
            }
            [HttpGet]
            public async Task<IActionResult> get_behaviours_status()
            {
                var result = await _service.get_behaviours_status();
                return Ok(result);
            }
            [HttpGet]
            public async Task<IActionResult> get_behaviours_status_with_id(int id)
            {

                var result = await _service.get_behaviours_status_with_id(id);
                return Ok(result);
            }

            [HttpPost]
            public async Task<IActionResult> save_in_behaviours_status(behaviours_status behaviours_status)
            {
                var result = await _service.save_in_behaviours_status(behaviours_status);
                return Ok(result);
            }

            [HttpPut]
            public async Task<IActionResult> update_behaviours_status(behaviours_status behaviours_status)
            {
                var result = await _service.update_behaviours_status(behaviours_status);
                return Ok(result);
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> delete_from_behaviours_status(int id)
            {


                var result = await _service.delete_from_behaviours_status(id);

                return Ok(result);
            }


        [HttpGet]
        public async Task<IActionResult> get_behaviours_status_details()
        {
            var result = await _service.get_behaviours_status_details();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_behaviours_status_details_with_id(int id)
        {

            var result = await _service.get_behaviours_status_details_with_id(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> save_in_behaviours_status_details(behaviours_status_details behaviours_status_details)
        {
            var result = await _service.save_in_behaviours_status_details(behaviours_status_details);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> update_behaviours_status_details(behaviours_status_details behaviours_status_details)
        {
            var result = await _service.update_behaviours_status_details(behaviours_status_details);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> delete_from_behaviours_status_details(int id)
        {


            var result = await _service.delete_from_behaviours_status_details(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> get_behaviours_status_details_with_behaviour_status_id(int id)
        {

            var result = await _service.get_behaviours_status_details_with_behaviour_status_id(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get_behaviours_status_details_with_student_id(int id)
        {

            var result = await _service.get_behaviours_status_details_with_student_id(id);
            return Ok(result);
        }
    }
    }

