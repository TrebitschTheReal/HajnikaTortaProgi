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

            for (int i = 0; i < data.Materials.Capacity; i++)
            {
                Console.WriteLine("{0}. {1}",i ,data.Materials[i].Name);
            }

            Console.ReadLine();



        }
    }
}
