using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
//using Common;
namespace ConsoleApp2
{

    public enum Days  // :int  defult
    {
        saturday,
        sunday,
        monday,
        tuesday,
        wednesday,
        thrusday,
        friday
    }
    public enum Grades
    {
        A=10,B=20,C=30,D=40,F=50
    }
    public enum Gender
    {
        male=1,female=2
    }
   public enum branches:byte //8 bite 0:255
    {
        dokki,maddi,smartvallege,
    }
    internal class demo
    {
        //static void dosomecode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine());//System.FormatException
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y;//System.DivideByZeroException

        //        int[] numbers = { 1, 2, 3, 4, 5 };
        //        numbers[10] = 20;//System.IndexOutOfRangeException
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine(ex.Message);
        //    }

        //}
        //static void DoSomeProtectiveCode()
        //{
        //    int x, y, z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("Enter first number");
        //        flag = int.TryParse(Console.ReadLine(), out x);

        //    } while (!flag);
        //    do
        //    {
        //        Console.WriteLine("Enter second number");
        //        flag = int.TryParse(Console.ReadLine(), out y);

        //    } while (!flag || y == 0);

        //    z = x / y;
        //    int[] number = { 1, 2, 3, };
        //    if (number?.Length > 10) {
        //        number[10] = 22;

        //    }

        //}



        static void Main(string[] args)
        {
            #region exception handling and protective code
            //dosomecode();
            //try
            //{
            //    DoSomeProtectiveCode();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region access modifier
            //typeA a =new typeA();//valid
            ////TypeB b = new Common.TypeB(); //invalid[internal]
            ////a.x = 19; // inbalid bc of protectoion level
            //a.y = 3; // invalid bc y is internal
            //a.z = 4;//valid bc its public

            #endregion

            #region enum
            #region ex 1
            //Days day =  Days.sunday;
            //Grades x = Grades.A;
            //Console.WriteLine(x);
            //if (x == Grades.A) 
            //    Console.WriteLine(":)");
            //  else
            //     Console.WriteLine(":(");

            //Grades y = (Grades)2;//explicit casting
            //Console.WriteLine(y);

            //Grades z = (Grades)10;//explicit casting (wrong)
            //Console.WriteLine(z);
            #endregion
            #region ex 2
            //Console.WriteLine("plz enter your grade");
            //bool result=Enum.TryParse(typeof(Grades),Console.ReadLine(), out object x);
            //Console.WriteLine($" your grade is {result}");
            //Console.WriteLine($"your grade is {x}");
            #endregion
            #region ex3
            //string gender = "MAle";
            //Gender x = (Gender)gender;
            //Enum.TryParse(typeof(Gender), gender, out object x);
            ////bool flag=Enum.TryParse<Gender>(gender, true, out Gender x);
            //Console.WriteLine(flag);
            //Console.WriteLine(x);
            //لاتجعل enum start with zero 
            #endregion
            #endregion
        }



    }
     public enum Role
    {
        admin=10,editor=20,viewer=30
    }
        class employee
        {
            string name;//varchar
            int age;//int
          Gender gender;//0-1
    Role role;
         
        }
    }
    

