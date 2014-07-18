using System;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			double[] d = new double[] { 0 };

			Console.WriteLine (d.IsArrayOf<double>());

			Console.ReadKey ();
		}
	}
}
