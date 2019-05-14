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
            OpearationsWithMaterials ops = new OpearationsWithMaterials(data);







            Export.ExportOutToCsv(data);
            Console.Write("Nyomj egy gombot a kilépéshez . . . ");
            Console.ReadKey();
        }
    }
}
