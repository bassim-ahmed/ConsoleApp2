using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace ConsoleApp2
{
    internal class demo
    {
        static void dosomecode()
        {
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine());//System.FormatException
                y = int.Parse(Console.ReadLine());
                z = x / y;//System.DivideByZeroException

                int[] numbers = { 1, 2, 3, 4, 5 };
                numbers[10] = 20;//System.IndexOutOfRangeException
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
        static void DoSomeProtectiveCode()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("Enter first number");
                flag = int.TryParse(Console.ReadLine(), out x);

            } while (!flag);
            do
            {
                Console.WriteLine("Enter second number");
                flag = int.TryParse(Console.ReadLine(), out y);

            } while (!flag || y == 0);

            z = x / y;
            int[] number = { 1, 2, 3, };
            if (number?.Length > 10) {
                number[10] = 22;

            }

        }


        static void Main(string[] args)
        {
            #region exception handling and protective code
            //dosomecode();
            try
            {
                DoSomeProtectiveCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
            #region access modifier
            typeA a =new typeA();//valid
            //TypeB b = new Common.TypeB(); //invalid[internal]
            //a.x = 19; // inbalid bc of protectoion level
            a.y = 3; // invalid bc y is internal
            a.z = 4;//valid bc its public

            #endregion


        }
    }
    }

