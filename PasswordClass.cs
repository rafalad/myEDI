using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDISupportTool
{
    public class PasswordGen
    {
        [STAThreadAttribute]
        public void PasswordGene()
        {
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);

            Colors set = new Colors();
            Kit set2 = new Kit();

            set.DoIt();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("\n\n=== Password has been copied to the clipboard. Press any key to continue... ===");
            Clipboard.SetText(PasswordGenerator.NewPassword());

            Console.ReadKey();

            //set2.Short_menu();
        }
    }
}
