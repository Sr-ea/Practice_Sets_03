namespace PS03_P02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Create a function that determines whether a given year is a leap year or not.
            Console.Write("Enter the year here:");
            int yr = int.Parse(Console.ReadLine());

            bool year = leapyearchecker(yr);
            if (!year)
            {
                Console.WriteLine($"The year {yr} is not a leap year");
            }

            else
            {
                Console.WriteLine($"The year {yr} is a leap year");
            }
        }

        public static bool leapyearchecker(int yr)
        {
           return (yr % 4 ==0 && yr % 100 != 0) || yr % 400 == 0;
        }
    }
}
