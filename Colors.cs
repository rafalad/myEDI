using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDISupportTool
{
    public class Colors
    {
        public class ColoredString
        {
            public ConsoleColor Color;
            public String Text;

            public ColoredString(ConsoleColor color, string text)
            {
                Color = color;
                Text = text;
            }
        }

        public static void WriteConsoleColor(params ColoredString[] strings)
        {
            var originalColor = Console.ForegroundColor;
            foreach (var str in strings)
            {
                Console.ForegroundColor = str.Color;
                Console.Write(str.Text);
            }

            Console.ForegroundColor = originalColor;
        }

        public void DoIt()
        {
            WriteConsoleColor(new ColoredString(ConsoleColor.DarkYellow, "\nMy password is: "));
            WriteConsoleColor(new ColoredString(ConsoleColor.Red, PasswordGenerator.NewPassword()));
        }

        public void doColorFolder()
        {
            Kit set = new Kit();
            WriteConsoleColor(new ColoredString(ConsoleColor.DarkYellow, "\nFolder has been created in: "));
            WriteConsoleColor(new ColoredString(ConsoleColor.Green, set.folder_path));
        }
    }
}
