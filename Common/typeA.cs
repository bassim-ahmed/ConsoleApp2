using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common
{
    //valid within its project and external project with import
    public class typeA
    {
        public typeA() { 
            //TypeB b = new TypeB();
            private int x;//accecible within its scope only
           internal int y;//accecible within its scope and its project
        public int z;//accecible within its scope and its project and external project 
        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);//valid
            Console.WriteLine(z);//valid
        }

        }

    }
}
