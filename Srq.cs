using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDISupportTool
{
    public class Srq
    {
        public void newSRQ()
        {
            Kit set = new Kit();
            Console.WriteLine("\n");
            set.CreateDirEDI();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.WriteLine(@"FYI: All objects will be created in C:\EDI");
            Console.ResetColor();
            Console.Write("\nEnter the SRQ number you are working on: ");
            string srq_no = Console.ReadLine();
            long int_no;

            bool convert = long.TryParse(srq_no, out int_no);

            if (!convert)
            {
                //jezeli nie wprowadzono liczby
                Console.WriteLine("\nEnter numbers, not letters.");
                Srq srq = new Srq();
                srq.newSRQ();
            }

            else
            {
                // jezeli wprowadzono liczbe
                set.CreateDirSRQ(int_no);
            }
        }
        /*
        public void Back()
        {
            Program start = new Program();
            Program.Main();
        } */
    }
}
