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

        [HttpGet]
        [Route("DayTwo")]
        public int dayTwoAction()
        {
            var _dayTwoService = new DayTwoService();
            return _dayTwoService.dayTwoChallenge(getDay2Data());
        }

        [HttpGet]
        [Route("DayTwoPart2")]
        public int dayTwoPart2Action()
        {
            var _dayTwoService = new DayTwoService();
            return _dayTwoService.dayTwoPart2Challenge(getDay2Data());
        }

        #region Private Methods

        private List<List<int>> getDay2Data()
        {
            List<List<int>> lines = new List<List<int>>();
            string line;
            StreamReader sr = new StreamReader("C:\\Users\\Caleb\\source\\repos\\advent-of-code-2024-csharp\\AdventOfCode2024\\SampleData\\Day2Data.txt");
            line = sr.ReadLine();
            lines.Add(line?.Split([' ']).Select(int.Parse).ToList());
            while (line != null)
            {
                lines.Add(line?.Split([' ']).Select(int.Parse).ToList());
                line = sr.ReadLine();
            }

            return lines;
        }

        #endregion
    }
}
