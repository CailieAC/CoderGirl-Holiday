using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter date you are leaving on vacation: ");
            DateTime dayLeaving = DateTime.Parse(Console.ReadLine());
            Console.Write("How many days will you be gone: ");
            int daysGone = int.Parse(Console.ReadLine());

            DayOfWeek dayOfReturn = DayReturning(dayLeaving, daysGone);

            Console.WriteLine(dayOfReturn);
            Console.ReadLine();
        }

        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.
        public static DayOfWeek DayReturning(DateTime dayLeaving, int daysGone)
        {
            DayOfWeek dayOfReturn;
            dayOfReturn = dayLeaving.AddDays(daysGone).DayOfWeek;
            return dayOfReturn;
        }
    }
}
