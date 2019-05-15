﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HajnikaTortaProgi
{
    class Export
    {
        private static string accesPath = "E:\\HajnikaTortaProgi\\autosave_latestCake.csv";

        public static void AutoSave(DataBase data)
        {
            StreamWriter sw = new StreamWriter(accesPath, false, Encoding.Default);

            sw.WriteLine("Név;EgységTípus;Egységár;Mennyiség;Végösszeg");
            for (int i = 0; i < data.Materials.Count; i++)
            {
                sw.Write(data.Materials[i].Name + ";");
                sw.Write(data.Materials[i].UnitType + ";");
                sw.Write(data.Materials[i].UnitPrice + ";");
                sw.Write(data.Materials[i].UnitQuantity + ";");
                sw.Write(data.Materials[i].OverallPrice + ";");
                sw.WriteLine();
            }
            sw.Close();
            Console.WriteLine("\n\n" + "Auto mentés: {0}", accesPath);
        }

        public static void SaveTheCake(DataBase data)
        {
            Console.Write("Mi legyen a torta neve?: ");
            string cakeName = Console.ReadLine();
            string newAccesPath = "E:\\HajnikaTortaProgi\\" + cakeName + ".csv";

            StreamWriter sw = new StreamWriter(newAccesPath, false, Encoding.Default);

            sw.WriteLine("Név;EgységTípus;Egységár;Mennyiség;Végösszeg");
            for (int i = 0; i < data.Materials.Count; i++)
            {
                sw.Write(data.Materials[i].Name + ";");
                sw.Write(data.Materials[i].UnitType + ";");
                sw.Write(data.Materials[i].UnitPrice + ";");
                sw.Write(data.Materials[i].UnitQuantity + ";");
                sw.Write(data.Materials[i].OverallPrice + ";");
                sw.WriteLine();
            }
            sw.Close();
            Console.WriteLine("\n\n" + "Elmentve: {0}", newAccesPath);

        }
    }
} 