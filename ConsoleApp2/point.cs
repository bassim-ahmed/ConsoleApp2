using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct   Point
    {
        // Access Modifier Allowed Inside Struct?
        //1. Private[Default]
        //2. Internal
        //3. Public

        //What You Can Write Inside The Struct Or Class
        // 1. Attributes[Fields] => Member Variable  
        //public int x; 
        //public int y;
        // 2. Functions[Constructor, Getter Setter, Method]
          //constructor ==>is special type of function
               //1-always named with same name or struct or class
               //2= has no return
        //By Default=>compiler will always generate parameterLess constructor
        //that initialize attribute of struct with default value pf its datatype 
               //public point()
               //  {
               //    x=1; y=0;//valid from c# 6.0

               //    }
        //       public Point(int _x, int _y)
        //{
        //    x = _x;
        //    y = _y;

        //}
        //public Point(int number)
        //{
        //    x = y = number;
        //}


        // 3. Properties[Full Property, Automatic Property, Indexer]
        // 4. Events

    }
}
