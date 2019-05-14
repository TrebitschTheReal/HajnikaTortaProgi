using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajnikaTortaProgi
{
    class OpearationsWithMaterials
    {
        public OpearationsWithMaterials(DataBase data)
        {
            while (true)
            {
                DisplayMaterials(data);
                MenuSwitch(data);
            }

        }
        public void DisplayMaterials(DataBase data)
        {
            int cursorDefault = 18;
            int cursorNewLine = 0;

            int cnt = 1;

            for (int i = 0; i < data.Materials.Count; i++)
            {
                Console.Write("{0}. {1}", cnt, data.Materials[i].Name);
                Console.SetCursorPosition(cursorDefault, cursorNewLine);
                Console.Write("Jelenlegi mennyiség: {0} {1}", data.Materials[i].UnitQuantity, data.Materials[i].UnitType);
                cursorNewLine++;
                Console.SetCursorPosition(0, cursorNewLine);
                Console.WriteLine("===================================================");
                cursorNewLine++;
                Console.SetCursorPosition(0, cursorNewLine);
                cnt++;
            }
        }
        public void MenuSwitch(DataBase data)
        {
            int choosedElement = 0;
            choosedElement = int.Parse(Console.ReadLine());
            choosedElement -= 1;
            int cursorDefault = 18;
            int cursorNewLine = 0;

            for (int i = 0; i < data.Materials.Count; i++)
            {
                if(choosedElement == i)
                {
                    Console.Clear();
                    Console.Write("{0}", data.Materials[i].Name);
                    Console.SetCursorPosition(cursorDefault, cursorNewLine);
                    Console.Write("Jelenlegi mennyiség: {0} {1}", data.Materials[i].UnitQuantity, data.Materials[i].UnitType);
                    cursorNewLine++;
                    Console.SetCursorPosition(0, cursorNewLine);
                    Console.WriteLine("===================================================");
                    cursorNewLine++;
                    Console.SetCursorPosition(0, cursorNewLine);
                    WhatOperationToDo(data, choosedElement);
                }

            }
        }
        public void WhatOperationToDo(DataBase data, int materialIndex)
        {
            Console.WriteLine("Mit szeretnél csinálni?");
            Console.WriteLine("1. Hozzáadni");
            Console.WriteLine("2. Elvenni");

            int menuChoose = 0;
            menuChoose = int.Parse(Console.ReadLine());

            if(menuChoose == 1)
            {
                Console.Write("Kérlek írd be mennyit fogsz hozzáadni: ");
                OperationAdd(data, materialIndex);
                Export.ExportOutToCsv(data);
                Console.Clear();
            }
            else if(menuChoose == 2)
            {
                Console.Write("Kérlek írd be mennyit vennél el: ");
                OperationSubtract(data, materialIndex);
                Export.ExportOutToCsv(data);
                Console.Clear();
            }
        }
        public void OperationAdd(DataBase data, int materialIndex)
        {
            int addValue = int.Parse(Console.ReadLine());
            data.Materials[materialIndex].UnitQuantity += addValue;
        }
        public void OperationSubtract(DataBase data, int materialIndex)
        {
            int subValue = int.Parse(Console.ReadLine());
            data.Materials[materialIndex].UnitQuantity -= subValue;
        }
    }
}
