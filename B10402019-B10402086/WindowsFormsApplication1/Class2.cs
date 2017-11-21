using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Class2
	{
        public bool Prime_number(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return true;
            }
            return false;
        }
	}
}
