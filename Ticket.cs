using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myEDI
{
	class Ticket
	{
        public string createdfolder;
		public void NewTicket(string CHWnoField, string idField, string task)
		{
            string type = string.Empty;
            string no = string.Empty;


            string type_srq = "DSV_SRQ";
            string type_inc = "DSV_INC";

            string type_srq_folder = "SRQ";
            string type_inc_folder = "INC";


            //przechodzę o po znakach w poszukiwania liczb, jeżeli znajdę to przypisuję do zmiennej
            for (int i = 0; i < CHWnoField.Length; i++)
            {
                if (Char.IsDigit(CHWnoField[i]))
                    no += CHWnoField[i];

            }
            //przechodzę o po znakach w poszukiwania liter, jeżeli znajdę to przypisuję do zmiennej
            for (int i = 0; i < CHWnoField.Length; i++)
            {
                if (Char.IsLetter(CHWnoField[i]))
                    type += CHWnoField[i];
            }

            if (type == "Incident")
            {
                string folderName = type_inc_folder + no + " - " + idField + task;
                string dir = @"C:\EDI\" + folderName + @"\RT";
                Directory.CreateDirectory(dir);

                string rt_name = type_inc + no + "_" + idField + "_1.0_rt";
                File.Create(dir + @"\" + rt_name);

                createdfolder = @"C:\EDI\" + folderName;
            }
            else
            {
                string folderName = type_srq_folder + no + " - " + idField + task;
                string dir = @"C:\EDI\" + folderName + @"\RT";
                Directory.CreateDirectory(dir);

                string rt_name = type_srq + no + "_" + idField + "_1.0_rt";
                string exp_name = type_srq + no + "_" + idField + "_1.0_exp";
                string ffid_name = type_srq + no + "_" + idField + "_1.0_ffid";
                string fser_name = type_srq + no + "_" + idField + "_1.0_fser";
                string fror_name = type_srq + no + "_" + idField + "_1.0_fror";

                File.Create(dir + @"\" + rt_name);
                File.Create(dir + @"\" + exp_name);
                File.Create(dir + @"\" + ffid_name);
                File.Create(dir + @"\" + fser_name);
                File.Create(dir + @"\" + fror_name);

                createdfolder = @"C:\EDI\" + folderName;
            }
        }
			
	}
}
