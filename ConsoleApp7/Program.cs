using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite y");
            int y = Convert.ToInt32(Console.ReadLine());
            try
            {
                int z = x / y;
                Console.WriteLine(z);
            }
            catch
            {
                Console.WriteLine("Isklucheniye");
            }
            try
            {
                int z = x / y;
                if (x == 0)
                {
                    throw new Exception("Z = 0");
                }
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
