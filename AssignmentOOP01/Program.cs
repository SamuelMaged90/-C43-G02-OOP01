using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
            //WeekDays weekDay = new WeekDays();
            //weekDay = (WeekDays)127;
            //Console.WriteLine(weekDay);
            ///*************** Or ****************/
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region 2- Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season;
            //bool state;
            //do
            //{
            //    Console.WriteLine("Enter Season");
            //    state = Enum.TryParse<Season>(Console.ReadLine(), out season);
            //} while (!state);
            //Season season01 = new Season();
            //season01 = season;
            //if (season01 == Season.Spring)
            //{
            //    Console.WriteLine("March to May");
            //}
            //else if (season01 == Season.Winter)
            //{
            //    Console.WriteLine("December to February");
            //}
            //else if (season01 == Season.Summer)
            //{
            //    Console.WriteLine("june to august");
            //}
            //else if ((season01 == Season.Autumn))
            //{
            //    Console.WriteLine("September to November ");
            //}
            #endregion
            #region 3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum - Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
            //Permissions permission = new Permissions();

            ///* To Add Read Permission */
            //permission ^= Permissions.Read;
            //Console.WriteLine(permission);
            ///* To Remove Read Permission*/
            //permission ^= Permissions.Read;
            //Console.WriteLine(permission);
            ///* To check if it exist, remove - if not , ok */
            //if ((permission &= Permissions.Read) == Permissions.Read)
            //{
            //    permission ^= Permissions.Read;
            //}
            //Console.WriteLine(permission);
            ///* To Check if the permission exist , Ok --- if not , add it */
            //permission |=Permissions.Read;
            //Console.WriteLine(permission);
            #endregion
            #region 4- Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //bool isparsed;
            //Colors color;
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter Color");
            //     input = Console.ReadLine();
            //} while (input is null);

            //Enum.TryParse<Colors>(input, out color);

            //if (color == Colors.Blue || color == Colors.Green || color == Colors.Red)
            //{
            //    Console.WriteLine("the input color is a primary color ");
            //}
            //else
            //{
            //    Console.WriteLine("the input color is not a primary color ");
            //}



            #endregion
        }
    }
}
