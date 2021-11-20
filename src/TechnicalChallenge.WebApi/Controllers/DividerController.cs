using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalChallenge.Core.Dtos;
using TechnicalChallenge.Core.Entities;
using TechnicalChallenge.Manager.Interfaces;

namespace TechnicalChallenge.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DividerController : ControllerBase
    {
        private readonly IDividerManager _dividerManager;
        public DividerController(IDividerManager dividerManager)
        {
            _dividerManager = dividerManager;
        }

        [HttpGet("{number}")]
        [ProducesResponseType(typeof(DividerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DividerResponse), StatusCodes.Status400BadRequest)]
        public IActionResult Get(long number)
        {
            var divider = new Divider
            {
                Number = number
            };

            var dividerResponse = _dividerManager.GetDividersAndPrimeNumbers(divider);
            if (!dividerResponse.IsSuccess)
            {
                return BadRequest(dividerResponse);
            }

            return Ok(dividerResponse);
        }
    }
}
