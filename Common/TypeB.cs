using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB() { 
        typeA a=new typeA();
            //valid within its project
            //typeA.x = 10;//invalid
            // x is privite
            a.y = 28;//valid
            a.z = 23;//valid bc its public
        }
    }
}
