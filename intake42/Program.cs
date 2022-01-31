using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intake42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result= Sub.subfun(9, 7);
            Console.WriteLine(result);
            sum sum1 = new sum();
            double mySum = sum1.sumfunction(3, 4);
            Console.WriteLine("sum = "+mySum);
        }
    }
}
