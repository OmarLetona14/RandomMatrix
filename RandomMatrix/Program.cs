using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMatrix
{
    class Program
    {
        static RandomNumber random = new RandomNumber();

        static void Main(string[] args)
        {
            random.generateMatrix();
            Console.ReadLine();
        }


    }
}
