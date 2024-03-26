using DiMultipleImplementationOfSameInterface.Services.Implementations;
using DiMultipleImplementationOfSameInterface.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiMultipleImplementationOfSameInterface.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class NumbersController : ControllerBase
    {

        private readonly INumberService _randomNumberService;
        private readonly INumberService _threeNumberService;
        private readonly INumberService _fiveNumberService;

        public NumbersController(
        /*
         * For Keyed Services -> NET 8 feature
        [FromKeyedServices("random")] INumberService randomNumberService,
        [FromKeyedServices("three")] INumberService threeNumberService,
        [FromKeyedServices("five")] INumberService fiveNumberService
        */
            IEnumerable<INumberService> services
         )
        {
            /*
            _randomNumberService = randomNumberService;
            _threeNumberService = threeNumberService;
            _fiveNumberService = fiveNumberService;
            */
            _randomNumberService = services.Single(s => s is RandomNumberService);
            _threeNumberService = services.Single(s => s is ThreeNumberService);
            _fiveNumberService = services.Single(s => s is FiveNumberService);
        }

        [HttpGet("three", Name = "three")]
        public int GetNumberThree()
        {
            return _threeNumberService.GetNumber();
        }

        [HttpGet("five", Name = "five")]
        public int GetNumberFive()
        {
            return _fiveNumberService.GetNumber();
        }

        [HttpGet("random", Name = "random")]
        public int GetRandomNumber()
        {
            return _randomNumberService.GetNumber();
        }
    }
}
