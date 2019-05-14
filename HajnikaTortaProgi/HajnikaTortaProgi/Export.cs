using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HajnikaTortaProgi
{
    static class Export
    {
        public static string accesPath = "E:\\HajnikaTortaProgi\\alapanyagok.csv";

        public static void ExportOutToCsv(DataBase data)
        {
            StreamWriter sw = new StreamWriter(accesPath, false, Encoding.Default);

            sw.WriteLine("Név;EgységTípus;Egységár;Mennyiség");
            for (int i = 0; i < data.Materials.Count; i++)
            {
                sw.Write(data.Materials[i].Name + ";");
                sw.Write(data.Materials[i].UnitType + ";");
                sw.Write(data.Materials[i].UnitPrice + ";");
                sw.Write(data.Materials[i].UnitQuantity + ";");
                sw.WriteLine();
            }
            sw.Close();
            Console.WriteLine("\n\n" + "Elmentve: {0}", accesPath);
        }
    }
} 