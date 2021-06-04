using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace myEDI
{
	public class Kit
	{
		public string deploymentsdir = @"C:\DEPLOYMENTS\DEPLOY";

		// Zwraca numer tygodnia dla Duńskiej strefy czasowej (CET)
		public int Week()
		{
			CultureInfo myCI = new CultureInfo("da-DK");
			Calendar myCal = myCI.Calendar;

			CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
			DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
			int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);

			return week;
		}

		//Pobiera dzień dla Duńskiej strefy czasowej (CET)
		public int Day()
		{
			CultureInfo myCI = new CultureInfo("da-DK");
			Calendar myCal = myCI.Calendar;

			int day = myCal.GetDayOfMonth(DateTime.Today);

			return day;
		}

		//Pobiera miesiąc po angielsku (domyślny język katalogów)
		public string Month()
		{
			CultureInfo myCI = new CultureInfo("en-UK");
			Calendar myCal = myCI.Calendar;

			string monthName = myCI.DateTimeFormat.GetMonthName(myCal.GetMonth(DateTime.Today));

			return monthName;
		}

		//Tworzy wiersz "Release Week (nr tygodnia) i nazwa folderu z którego czyta.
		public string Time1()
		{
			return ("" + "Release Week " + Week() + " " + DeployFolder());
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
	}
}
