
namespace AdventOfCode2024.Services
{
    public class DayOneService
    {
        public int dayOneChallenge(IEnumerable<int> locationIdSet1, IEnumerable<int> locationIdSet2)
        {
            return dayOneChallengeFirstSolve(locationIdSet1.ToList(), locationIdSet2.ToList());
        }

        public int dayOneChallengePart2(IEnumerable<int> locationIdSet1, IEnumerable<int> locationIdSet2)
        {
            return dayOneChallengePart2FirstSolve(locationIdSet1.ToList(), locationIdSet2.ToList());
        }

        private int dayOneChallengeFirstSolve(List<int> locationIdSet1, List<int> locationIdSet2)
        {
            int totalDistance = 0;
            while (locationIdSet1.Count() > 0)
            {
                int id1 = locationIdSet1.Min();
                int id2 = locationIdSet2.Min();
                int distance = Math.Abs(id1 - id2);
                totalDistance += distance;

                locationIdSet1.Remove(id1);
                locationIdSet2.Remove(id2);
            }

            if (totalDistance > 0) 
            { 
                return totalDistance;
            }

            // Fail case
            return -1;
        }
    
        public int dayOneChallengePart2FirstSolve(List<int> locationIdSet1, List<int> locationIdSet2)
        {
            var similarityScore = 0;
            foreach (int locationSet1Id in locationIdSet1)
            {
                int occurances = locationIdSet2.Where(x => x == locationSet1Id).Count();
                similarityScore += locationSet1Id * occurances;
            }

            if (similarityScore != 0)
            {
                return similarityScore;
            }

            // Fail Case
            return -1;
        }
    }
}
