using System;
using Gtk;

namespace project1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            Console.WriteLine();
			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();
		}
	}
}
