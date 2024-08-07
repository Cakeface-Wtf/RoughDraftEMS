namespace EMS.Core.Utility
{
    public static class ExitProgram
    {
        public static void Exit(int end = 0) //Exit Program
        {
            Console.WriteLine("Program is closing...Goodbye!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Environment.Exit(end);
        }
    }
}
