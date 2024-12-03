
namespace AdventOfCode2024.Services
{
    public class DayTwoService
    {
        public int dayTwoChallenge(List<List<int>> inputData)
        {
            return dayTwoChallengeFirstSolve(inputData);
        }

        public int dayTwoPart2Challenge(List<List<int>> inputData)
        {
            return dayTwoChallengePart2FirstSolve(inputData);
            //return dayTwoChallengePart2SecondSolve(inputData);
        }

        private int dayTwoChallengeFirstSolve(List<List<int>> inputData)
        {
            int passedReports = 0;
            foreach (var list in inputData)
            {
                int direction = Math.Sign(list[0] - list[1]);
                if (direction == 0)
                {
                    continue;
                }
                for (int i = 0; i < list.Count - 1; i++)
                {
                    int difference = list[i] - list[i + 1];
                    if (Math.Abs(difference) > 3 || (Math.Sign(difference) != Math.Sign(direction)))
                    {
                        break;
                    }

                    if (i == list.Count - 2) 
                    {
                        passedReports++;
                    }
                }
            }

            if (passedReports != 0)
            {
                return passedReports;
            }

            // Fail case
            return -1;
        }

        private int dayTwoChallengePart2FirstSolve(List<List<int>> inputData)
        {
            int newlyPassingReports = 0;
            foreach (var list in inputData)
            {
                int direction = Math.Sign(list[0] - list[1]);

                if (direction == 0)
                {
                    continue;
                }

                int mistakes = 0;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    int difference = list[i] - list[i + 1];
                    if (Math.Abs(difference) > 3 || (Math.Sign(difference) != Math.Sign(direction)))
                    {
                        if (mistakes == 0)
                        {
                            mistakes++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // We no longer care for the normal passing reports
                    if (i == list.Count - 2)
                    {
                        newlyPassingReports++;
                    }
                }
            }

            if (newlyPassingReports != 0)
            {
                return newlyPassingReports;
            }

            // Fail case
            return -1;
        }

        private int dayTwoChallengePart2SecondSolve(List<List<int>> inputData)
        {
            int newlyPassingReports = 0;
            foreach (var list in inputData)
            {
                int direction = Math.Sign(list[0] - list[1]);

                if (direction == 0)
                {
                    continue;
                }

                int mistakePosition = 0;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    int difference = list[i] - list[i + 1];
                    if (Math.Abs(difference) > 3 || (Math.Sign(difference) != Math.Sign(direction)))
                    {
                        mistakePosition = i+1;
                        break;
                    }

                    if (i == list.Count - 2)
                    {
                        newlyPassingReports++;
                    }
                }

                if (mistakePosition > 0)
                {
                    list.RemoveAt(mistakePosition);
                    int retryDirection = Math.Sign(list[0] - list[1]);
                    if (retryDirection == 0)
                    {
                        continue;
                    }
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        int difference = list[i] - list[i + 1];
                        if (Math.Abs(difference) > 3 || (Math.Sign(difference) != Math.Sign(retryDirection)))
                        {
                            break;
                        }

                        if (i == list.Count - 2)
                        {
                            newlyPassingReports++;
                        }
                    }
                }
            }

            if (newlyPassingReports != 0)
            {
                return newlyPassingReports;
            }

            // Fail case
            return -1;
        }
    }
}
