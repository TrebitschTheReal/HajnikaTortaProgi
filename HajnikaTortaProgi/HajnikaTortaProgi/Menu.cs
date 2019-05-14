//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HajnikaTortaProgi
//{
//    class Menu
//    {
//        private static int index = 0;

//        public Menu(DataBase data)
//        {
//            MenuMain(data);

//        }


//        private void MenuMain(DataBase data)
//        {
//            List<string> menuItems = new List<string>()
//            {
//                data.Materials[0].Name,
//                data.Materials[1].Name,
//                data.Materials[2].Name,
//                data.Materials[3].Name,
//                data.Materials[4].Name,
//                "Exit"
//            };

//            Console.CursorVisible = false;
//            while (true)
//            {
//                string selectedMenuItem = drawMenu(menuItems);
//                if (selectedMenuItem == data.Materials[0].Name)
//                {
//                    Console.Clear();
//                    Console.WriteLine("HELLO one!"); Console.Read();
//                }
//                else if (selectedMenuItem == "Exit")
//                {
//                    Environment.Exit(0);
//                }
//            }
//        }

//        private static string drawMenu(List<string> items)
//        {
//            for (int i = 0; i < items.Count; i++)
//            {
//                if (i == index)
//                {
//                    Console.BackgroundColor = ConsoleColor.Gray;
//                    Console.ForegroundColor = ConsoleColor.Black;

//                    Console.WriteLine(items[i]);
//                }
//                else
//                {
//                    Console.WriteLine(items[i]);
//                }
//                Console.ResetColor();
//            }

//            ConsoleKeyInfo ckey = Console.ReadKey();

//            if (ckey.Key == ConsoleKey.DownArrow)
//            {
//                if (index == items.Count - 1)
//                {
//                    //index = 0; //Remove the comment to return to the topmost item in the list
//                }
//                else { index++; }
//            }
//            else if (ckey.Key == ConsoleKey.UpArrow)
//            {
//                if (index <= 0)
//                {
//                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
//                }
//                else { index--; }
//            }
//            else if (ckey.Key == ConsoleKey.Enter)
//            {
//                return items[index];
//            }
//            else
//            {
//                return "";
//            }

//            Console.Clear();
//            return "";
//        }
//    }
//}
