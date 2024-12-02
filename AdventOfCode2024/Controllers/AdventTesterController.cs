using AdventOfCode2024.Dto;
using AdventOfCode2024.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2024.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdventTesterController : ControllerBase
    {
        [HttpPost]
        [Route("DayOnePart1")]
        public int dayOnePart1Action(DayOneInputData input)
        {
            var _dayOneService = new DayOneService();
            return _dayOneService.dayOneChallenge(input.firstListOfLocationIds, input.secondListOfLocationIds);
        }

        [HttpPost]
        [Route("DayOnePart2")]
        public int dayOnePart2Action(DayOneInputData input)
        {
            var _dayOneService = new DayOneService();
            return _dayOneService.dayOneChallengePart2(input.firstListOfLocationIds, input.secondListOfLocationIds);
        }
    }
}
