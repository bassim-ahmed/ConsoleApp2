using static Assignment.Program;
using System.Reflection;

namespace Assignment
{
    public class Employee
    {
        public string name;
        public int age;
        public decimal salary;
        public permission permission;
    }
    [Flags]
    public enum permission
    {
        Delete = 1, Excute = 2, Read = 4, Write = 8
    }
    internal class Program
    {
        #region 1
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion
        #region 2
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion
        #region 4
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion



        static void Main(string[] args)
        {

            #region 1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{

            //    Console.WriteLine(day);
            //}
            #endregion
            #region 2
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion
            #region 3
            //Employee emp = new Employee();
            //emp.name = "bassim";
            //emp.permission = (permission)3;
            //Console.WriteLine(emp.permission);

            ////if you want to add permission
            ////do xor operation
            //emp.permission = emp.permission ^ permission.Read;
            //Console.WriteLine(emp.permission);


            ////if you want to remove [deny]
            ////do xor operation
            //emp.permission = emp.permission ^ permission.Read;
            //Console.WriteLine(emp.permission);

            //emp.permission = emp.permission | permission.Read;
            //Console.WriteLine(emp.permission);

            #endregion
            #region 4
            //Console.WriteLine("Enter a color (Red, Green, Blue):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color name.");
            //}
            #endregion
            #region 5
            bool flag;
            Point point1 = new Point();
            Point point2 = new Point();
            do {
                Console.Write("Enter X coordinate for Point 1: ");
                flag = double.TryParse(Console.ReadLine(), out point1.X);
           

            }while (!flag) ;
            do
            {
                Console.Write("Enter y coordinate for Point 1: ");
                flag = double.TryParse(Console.ReadLine(), out point1.Y);


            } while (!flag);
            do
            {
                Console.Write("Enter x coordinate for Point 2: ");
                flag = double.TryParse(Console.ReadLine(), out point2.X);


            } while (!flag);

            do
            {
                Console.Write("Enter y coordinate for Point 2: ");
                flag = double.TryParse(Console.ReadLine(), out point2.Y);


            } while (!flag);

            double distance = CalculateDistance(point1, point2);
            Console.WriteLine($"The distance between the two points is: {distance}");
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
        #endregion

    }
   }

