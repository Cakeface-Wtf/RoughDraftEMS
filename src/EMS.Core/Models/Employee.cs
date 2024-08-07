

namespace EMS.Core.Models
{
    public class Employee 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime HireDate { get; set; }
        public string HireDateShort => CalculateShortDateString(HireDate);
        public TimeSpan TimeEmployed => CalculateTimeEmployed(HireDate);
        public int SenorityPosition => CalculateSenorityPosition();

        public Employee(int id, string firstName, string lastName, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
        }



        private static TimeSpan CalculateTimeEmployed(DateTime hireDate) 
        {
            return DateTime.Now - hireDate;
        }

        private int CalculateSenorityPosition() //Still not completed. Don't forget.
        {
            return SenorityPosition;
        }

        private static string CalculateShortDateString(DateTime hireDate)
        {
            return hireDate.ToShortDateString();
        }
    }
}
