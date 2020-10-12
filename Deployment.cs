using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDISupportTool
{
    class Deployment
    {
        public static int index = 0;

        public void DeployNote()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);

            Kit set = new Kit();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Deployment Note Wizard for MS Teams.");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::\n");
            Console.ResetColor();

            set.CreateDirDEPLOYMENTS();
            set.TimeData();
            set.SelectRightFolder();

            Console.WriteLine(set.option);

            List<string> menuItems = new List<string>() {
                "\n  QA",
                "  PROD",
                "  both - QA & PROD",
                "\nExit"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string selectedMenuItem = drawMenu(menuItems);
                if (selectedMenuItem == "\n  QA")
                {
                    Console.Clear();

                    Console.WriteLine("\n");
                    new Qa();
                    Console.WriteLine("\n");
                }

                else if (selectedMenuItem == "  PROD")
                {
                    Console.Clear();

                    Console.WriteLine("\n");
                    new Prod();
                    Console.WriteLine("\n");
                }

                else if (selectedMenuItem == "  both - QA & PROD")
                {
                    Console.Clear();

                    Console.WriteLine("\n");
                    new Qaprod();
                    Console.WriteLine("\n");
                }

                else if (selectedMenuItem == "\nExit")
                {
                    //set.Short_menu();
                }

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("Deployment Note Wizard for MS Teams.");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::\n");
                Console.ResetColor();

                set.CreateDirDEPLOYMENTS();
                set.TimeData();
                set.SelectRightFolder();

                Console.WriteLine(set.option);
            }
        }

        public static string drawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }

                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    //index = 0;
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
