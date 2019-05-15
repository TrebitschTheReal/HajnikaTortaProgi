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
            try
            {
                while (true)
                {
                    DisplayMaterials(data);
                    MenuSwitch(data);
                }
            }
            catch
            {
                Console.WriteLine("Bocsi, de én most kilépek, mert Error. Vagy valami ilyesmi");
                Console.WriteLine();
            }


        }
        public void DisplayMaterials(DataBase data)
        {

            Console.Clear();

            int cursorDefault = 18;
            int cursorNewLine = 0;
            int cursorToAllPrice = 50;

            int cnt = 1;

            for (int i = 0; i < data.Materials.Count; i++)
            {
                Console.Write("{0}. {1}", cnt, data.Materials[i].Name);
                Console.SetCursorPosition(cursorDefault, cursorNewLine);
                Console.Write("Jelenlegi mennyiség: {0} {1} ", data.Materials[i].UnitQuantity, data.Materials[i].UnitType);
                Console.SetCursorPosition(cursorToAllPrice, cursorNewLine);
                Console.Write("Alapanyag ára: {0} Ft", data.Materials[i].OverallPrice);
                cursorNewLine++;
                Console.SetCursorPosition(0, cursorNewLine);
                Console.WriteLine("==========================================================================");
                cursorNewLine++;
                Console.SetCursorPosition(0, cursorNewLine);
                cnt++;
            }

            Console.WriteLine("==========================================================================");
            Console.WriteLine("0. Kilépés");
            Console.Write("\nKérlek válassz: ");
        }
        public void MenuSwitch(DataBase data)
        {
            int choosedElement = 0;
            choosedElement = int.Parse(Console.ReadLine());
            choosedElement -= 1;
            int cursorDefault = 18;
            int cursorNewLine = 0;
            int cursorToAllPrice = 50;

            for (int i = 0; i < data.Materials.Count; i++)
            {
                if(choosedElement == i)
                {
                    Console.Clear();
                    Console.Write(" {0}", data.Materials[i].Name);
                    Console.SetCursorPosition(cursorDefault, cursorNewLine);
                    Console.Write("Jelenlegi mennyiség: {0} {1}", data.Materials[i].UnitQuantity, data.Materials[i].UnitType);
                    Console.SetCursorPosition(cursorToAllPrice, cursorNewLine);
                    Console.Write("Alapanyag ára: {0} Ft", data.Materials[i].OverallPrice);
                    cursorNewLine++;
                    Console.SetCursorPosition(0, cursorNewLine);
                    Console.WriteLine("==========================================================================");
                    cursorNewLine++;
                    Console.SetCursorPosition(0, cursorNewLine);
                    WhatOperationToDo(data, choosedElement);
                }

            }

            if (choosedElement == -1)
            {
                Console.Clear();
                Console.Write("Biztos ki akarsz lépni? I / N : ");
                char choose = Convert.ToChar(Console.ReadLine());
                if (choose == 'i')
                {
                    Export.SaveTheCake(data);
                    Environment.Exit(0);
                }
                else if (choose == 'n')
                {
                    DisplayMaterials(data);
                    MenuSwitch(data);
                }
            }
        }
        public void WhatOperationToDo(DataBase data, int materialIndex)
        {
            Console.WriteLine("Mit szeretnél csinálni?");
            Console.WriteLine();
            Console.WriteLine("1. Hozzáadni");
            Console.WriteLine("2. Elvenni");
            Console.WriteLine("");
            Console.WriteLine("3. Vissza");
            Console.Write("\n" + "Válassz: ");

            int menuChoose = 0;
            menuChoose = int.Parse(Console.ReadLine());

            if(menuChoose == 1)
            {
                Console.Write("\n" + "Kérlek írd be mennyit fogsz hozzáadni: ");
                OperationAdd(data, materialIndex);
                Export.AutoSave(data);
                Console.Clear();
            }
            else if(menuChoose == 2)
            {
                Console.Write("\n" + "Kérlek írd be mennyit vennél el: ");
                OperationSubtract(data, materialIndex);
                Export.AutoSave(data);
                Console.Clear();
            }
            else if(menuChoose == 3)
            {

            }
            Console.Clear();
        }
        public void OperationAdd(DataBase data, int materialIndex)
        {
            int addValue = int.Parse(Console.ReadLine());
            data.Materials[materialIndex].UnitQuantity += addValue;
        }
        public void OperationSubtract(DataBase data, int materialIndex)
        {
            int subValue = int.Parse(Console.ReadLine());
            if ((data.Materials[materialIndex].UnitQuantity - subValue) < 0)
            {
                data.Materials[materialIndex].UnitQuantity = 0;
            }
            else
            {
                data.Materials[materialIndex].UnitQuantity -= subValue;
            }
        }
    }
}
