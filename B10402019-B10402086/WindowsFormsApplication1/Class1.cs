using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public int GetNumber()
        {
            Random rand = new Random();
            int number = rand.Next(0, 99);
            return number;
        }   
    }
}
