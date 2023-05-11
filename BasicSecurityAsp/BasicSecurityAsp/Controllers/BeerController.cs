using BasicSecurityAsp.Models;
using BasicSecurityAsp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicSecurityAsp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BeerController : ControllerBase
    {
        private readonly IBeerService _beerService;
        
        public BeerController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        /// <summary>
        /// https://localhost:7294/api/beer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Beer>> Get()=> await _beerService.Get();
    }
}