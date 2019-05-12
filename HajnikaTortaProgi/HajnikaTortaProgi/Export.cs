using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HajnikaTortaProgi
{
    class Export
    {
        private static string accesPath = "E:\\HajnikaTortaProgi\\alapanyagok.csv";

        public void ExportOutToTxt(Cake)
        {
            StreamWriter sw = new StreamWriter(accesPath);

            for (int i = 0; i < Cake.Employees.GetLength(0); i++)
            {
                sw.WriteLine(Cake.Employees[i].Name);
                sw.WriteLine(Cake.Employees[i].Position);
                sw.WriteLine(Cake.Employees[i].WageInString + " Ft.");
                sw.WriteLine("Productivity: " + Cake.Employees[i].Productivity + " %");
                sw.WriteLine(Cake.Employees[i].MonitorType);
                sw.WriteLine(Cake.Employees[i].ProcessorType);
                sw.WriteLine(Cake.Employees[i].ProcessorPerformance + "Mhz.");
                sw.WriteLine("==============================");
            }
            sw.Close();
            Console.WriteLine("Exporting done to {0}", accesPath);
        }
    }
} 

}