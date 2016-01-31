using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            var result = numbers.Select(num => new { number = num })
                            .Select(x => x.number);

            foreach(var item in result)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}
