using BusinessLogic.Abstractions;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndividualCasesController : ControllerBase
    {
        private readonly I_IndividualCasesServices _individualCasesServices;

        public IndividualCasesController(I_IndividualCasesServices individualCasesServices)
        {
            _individualCasesServices = individualCasesServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetIndividualCases()
        {
            return Ok(await _individualCasesServices.GetIndividualCases());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetIndividualCaseById(int id)
        {
            return Ok(await _individualCasesServices.GetIndividualCaseById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveIndividualCase(IndividualCases student)
        {
            return Ok(await _individualCasesServices.SaveIndividualCase(student));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateIndividualCase(IndividualCases student)
        {
            return Ok(await _individualCasesServices.UpdateIndividualCase(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndividualCase(int id)
        {
            return Ok(await _individualCasesServices.DeleteIndividualCase(id));
        }
    }
}
