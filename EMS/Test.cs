using Employee_Management.EMS.UserInputChecks.IntChecks;
using Employee_Management.EMS.UserInputChecks.RangeChecks;

namespace Employee_Management.EMS
{
    public class Test
    {
        private readonly IIntCheck _checkInt;
        private readonly IRangeCheck _rangeChecker;

        public Test(IIntCheck checkInt, IRangeCheck rangeChecker)
        {
            _checkInt = checkInt;
            _rangeChecker = rangeChecker;
        }

        public void TrackAttempts(Func<bool> test, int maxAttempts = 5)
        {
            int failedAttempts = 0;

            while (true)
            {
                try
                {
                    if (true)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    failedAttempts++;
                    if (failedAttempts >= maxAttempts)
                    {
                        Console.WriteLine("Too many failed attempts. Program closing...Good Bye!");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
