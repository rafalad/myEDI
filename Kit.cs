using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace EDISupportTool
{
    public class Kit
    {
        public string currentdir = Directory.GetCurrentDirectory();
        public string deploymentsdir = @"C:\DEPLOYMENTS\DEPLOY";
        public string nazwa_folderu = Path.GetFileName(Directory.GetCurrentDirectory());
        public string option = "\nPlease select the deployment environment.";
        public string tytul = "Release Week ";
        public string dzisiaj = "Today is ";
        public string networkdrive = @"\\Dsv.com\corp\Userdocs\rafal.adamczyk\";
        public string folder_path;
        public string resourcefolder;
        public int folder_counter;


		// Zwraca numer tygodnia
		public int Week()
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);

            return week;
        }

        public int Day()
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            DateTime LastDay = new System.DateTime(DateTime.Now.Year, 12, 31);
            string monthName = myCI.DateTimeFormat.GetMonthName(myCal.GetMonth(DateTime.Today));
            int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            int day = myCal.GetDayOfMonth(DateTime.Today);

            return day;
        }

        public string Month()
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            DateTime LastDay = new System.DateTime(DateTime.Now.Year, 12, 31);
            string monthName = myCI.DateTimeFormat.GetMonthName(myCal.GetMonth(DateTime.Today));
            int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            int day = myCal.GetDayOfMonth(DateTime.Today);

            return monthName;
        }

        //Zwraca tydzień i datę, np Week 38, 15 September 2020
        public void TimeData()
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            DateTime LastDay = new System.DateTime(DateTime.Now.Year, 12, 31);
            string monthName = myCI.DateTimeFormat.GetMonthName(myCal.GetMonth(DateTime.Today));
            int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            int day = myCal.GetDayOfMonth(DateTime.Today);
            int year = myCal.GetYear(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWeek " + week + ", " + day + " " + monthName + " " + year);
            Console.ResetColor();
        }

        //Tworzy wiersz "Release Week (nr tygodnia) i nazwa folderu z którego czyta.
        public string Time1()
        {
            return ("" + tytul + "" + Week() + " " + DeployFolder());
        }

        //Tworzy wiersz np Today is Release Week 38
        public string Time2()
        {
            return ("" + dzisiaj + tytul + Week() + "");
        }

        //Metoda tworząca katalog, przyjmuje nazwę daty.
        public void CreateDir()
        {
            DateTime thisDay = DateTime.Today;
            string folderPath = @"C:\DEPLOYMENTS\2_Reports";
            string deployment_folder = Path.Combine(folderPath, thisDay.ToString("D"));
            string QAreports_folder = Path.Combine(deployment_folder, "QA_reports");
            string PRODreports_folder = Path.Combine(deployment_folder, "PROD_reports");

            Directory.CreateDirectory(deployment_folder);
            Directory.CreateDirectory(QAreports_folder);
            Directory.CreateDirectory(PRODreports_folder);
        }

        //Metoda nadająca nazewnictwo RT dla katalogu obiektów z SRQ, wywoływana przez Srq.cs tylko wtedy gdy user poda nr jako typ numeryczny long (parametr).
        public void CreateDirSRQ(long int_no)
        {
            Srq srq1 = new Srq();
            Console.Write("\nEnter the ID (e.g. customer name) of the ticket: ");
            string srq_id = Console.ReadLine();

            string folder_name = "DSV_SRQ" + int_no + "_" + srq_id + "_1.0_rt";
            string folder_path = Path.Combine(@"C:\EDI", folder_name);
            Directory.CreateDirectory(folder_path);

            Colors colors = new Colors();
            colors.doColorFolder();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(folder_path);
            Console.ResetColor();
            Console.WriteLine("\nPress any key to open the directory and exit to the main menu....");
            Console.ReadLine();
            Process.Start(@"C:\EDI");
            //srq1.Back();
        }

        //Sprawdza czy istnieje katalog C:\EDI i ewentualnie go tworzy.
        public void CreateDirEDI()
        {
            
            string folder_name = "EDI";
            string folder_path = Path.Combine(@"C:\", folder_name);

            bool folder = File.Exists(folder_path);

            if (Directory.Exists(folder_path))
            {
                MessageBox.Show("Directory creation will be skipped." + folder_path + " already exists.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(folder_path);
                MessageBox.Show("...a directory has been created to store EDI resources. " + "'" + folder_path + "'", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //Sprawdza czy istnieją katalogi C:\DEPLOYMENTS, C:\DEPLOYMENTS\DEPLOY, C:\DEPLOYMENTS\Reports , jeżeli nie to je tworzy.
        public void CreateDirDEPLOYMENTS()
        {
            string folder_name = "DEPLOYMENTS";
            string folder_name_deploy = "DEPLOY";
            string folder_name_reports = "Reports";
            string folder_path = Path.Combine(@"C:\", folder_name);
            string folder_path_deploy = Path.Combine(@"C:\DEPLOYMENTS", folder_name_deploy);
            string folder_path_reports = Path.Combine(@"C:\DEPLOYMENTS", folder_name_reports);
            string folder_path_reports_qa = Path.Combine(@"C:\DEPLOYMENTS\Reports", "QA");
            string folder_path_reports_prod = Path.Combine(@"C:\DEPLOYMENTS\Reports", "PROD");
            string folder_path_resources = Path.Combine(@"C:\DEPLOYMENTS", "RESOURCES");


            bool folder1 = File.Exists(folder_path);

            if (Directory.Exists(@"C:\" + folder_name))
            {
                MessageBox.Show(@"Directory creation will be skipped. 'C:\DEPLOYMENTS' already exists.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(folder_path);
                MessageBox.Show("...a directory has been created to store Deploment resources. " + "'" + folder_path + "'", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool folder2 = File.Exists(folder_path_deploy);

            if (Directory.Exists(@"C:\DEPLOYMENTS\DEPLOY"))
            {
                MessageBox.Show(@"Directory creation will be skipped. 'C:\DEPLOYMENTS\DEPLOY' already exists.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(folder_path_deploy);
                MessageBox.Show("...a directory has been created to store Deploment resources. " + "'" + folder_path_deploy + "'", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool folder3 = File.Exists(folder_path_reports);

            if (Directory.Exists(@"C:\DEPLOYMENTS\Reports"))
            {
                MessageBox.Show(@"Directory creation will be skipped. 'C:\DEPLOYMENTS\Reports' already exists.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(folder_path_reports);
                Directory.CreateDirectory(folder_path_reports_qa);
                Directory.CreateDirectory(folder_path_reports_prod);
                MessageBox.Show("...a directory has been created to store Report resources. " + "'" + folder_path_reports + "'", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool folder4 = File.Exists(folder_path_resources);

            if (Directory.Exists(@"C:\DEPLOYMENTS\RESOURCES"))
            {
                MessageBox.Show(@"Directory creation will be skipped. 'C:\DEPLOYMENTS\RESOURCES' already exists.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(folder_path_resources);
                MessageBox.Show("...a directory has been created to store Deploment resources. " + "'" + folder_path_resources + "'", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SelectRightFolder()
        {
            try
            {
                int dzien = Day();
                string miesiac = Month();

                // LINQ query.
                var dirs = from dir in
                         Directory.EnumerateDirectories(deploymentsdir, miesiac + "*" + dzien.ToString() + "*")
                           select dir;

                //Console.WriteLine("\nDirectory check result:");

                // Show results.
                /*
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var dir in dirs)
                {
                    // Remove path information from string.
                    
                    Console.WriteLine("{0}",
                        dir.Substring(dir.LastIndexOf("\\") + 1));
                }
                Console.WriteLine("{0} directories found.", dirs.Count<string>().ToString());
                Console.ResetColor();
                */

                if (dirs.Count<string>() == 0)
                {
                    MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                }
                
                
            }
            catch (UnauthorizedAccessException UAEx)
            {
                MessageBox.Show(UAEx.Message);
            }
            catch (PathTooLongException PathEx)
            {
                MessageBox.Show(PathEx.Message);
            }
        }

        //Metoda wyciągająca scieżkę i nazwę katalogu, w którym przechowywane są zasoby do wdrożenia.
        public string DeployPath()
        {
            int dzien = Day();
            string miesiac = Month();
            string sciezka = "0"; //zainicjowanie zmiennej lokalnej

            // LINQ query.
            var dirs = from dir in
                     Directory.EnumerateDirectories(deploymentsdir, miesiac + "*" + dzien.ToString() + "*")
                       select dir;

            var sciezka1 = Directory.EnumerateDirectories(deploymentsdir, miesiac + "*" + dzien.ToString() + "*");

            foreach (var dir in dirs)
            {
                sciezka = dir;
            }
            return sciezka;
        }

        //Metoda wyciągająca samą nazwę katalogu, w którym przechowywane są zasoby do wdrożenia.
        public string DeployFolder()
        {
            int dzien = Day();
            string miesiac = Month();
            string name = "0";

            // LINQ query.
            var dirs = from dir in
                     Directory.EnumerateDirectories(deploymentsdir, miesiac + "*" + dzien.ToString() + "*")
                       select dir;

            foreach (var dir in dirs)
            {
                // Remove path information from string.
                name = dir.Substring(dir.LastIndexOf("\\") + 1);
            }
            return name;
        }

        public void NewestFolder()
        {
            DateTime dt = Directory.GetCreationTime(deploymentsdir);
            // Give feedback to the user.
            if (DateTime.Now.Subtract(dt).TotalDays > 364)
            {
                Console.WriteLine("\nThis directory is over a year old.");
            }
            else if (DateTime.Now.Subtract(dt).TotalDays > 30)
            {
                Console.WriteLine("\nThis directory is over a month old.");
            }
            else if (DateTime.Now.Subtract(dt).TotalDays <= 1)
            {
                Console.WriteLine("\nThis directory is less than a day old.");
            }
            else
            {
                Console.WriteLine("\nThis directory was created on {0}", dt);
            }
        }
    }
}
