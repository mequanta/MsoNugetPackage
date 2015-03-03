using System;
using SmartQuant;

namespace TestSmartQuant.Origin
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var f = Framework.Current;
			f.InstrumentManager.Dump ();
			Console.WriteLine ();
			f.DataManager.Dump ();
			Console.WriteLine ("Done!");
		}
	}
}
