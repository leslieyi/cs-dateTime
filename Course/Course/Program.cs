using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson: DateTime Struct

            //Invoke Constructor
            //Parameters (year, month , day , hour, minute, second)

            var date1 = new DateTime(1994, 4, 11, 2, 30, 41);
            Console.WriteLine(date1);

            //DateTime Properties
            var date2 = DateTime.Now;
            var date3 = DateTime.UtcNow;
            Console.WriteLine(date2);
            Console.WriteLine(date3);


            //DateTime Methods
            var tmrw = date2.AddDays(1);
            Console.WriteLine("Tomorrow" + tmrw);

            //DateTime Formats
            Console.WriteLine(date2.ToLongDateString());
            Console.WriteLine(date2.ToShortDateString());
            Console.WriteLine(date2.ToLongTimeString());
            Console.WriteLine(date2.ToShortTimeString());


            //custom DateTime Format
            Console.WriteLine(date1.ToString("yyyy-MM-dd"));
        }
    }
}
