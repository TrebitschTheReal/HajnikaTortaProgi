using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajnikaTortaProgi
{
    class Program
    {
        static void Main()
        {
            DataBase data = new DataBase();

            Console.WriteLine(data.Materials[0].Name);
            Console.WriteLine(data.Materials[0].UnitType);
            Console.WriteLine(data.Materials[0].UnitPrice);

            Console.WriteLine("\n");

            Console.WriteLine(data.Materials[1].Name);
            Console.WriteLine(data.Materials[2].UnitType);
            Console.WriteLine(data.Materials[3].UnitPrice);



        }
    }
}
