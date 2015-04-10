using System;
using System.Linq;
using System.IO;
using MonoDevelop.Core;

namespace TestMonoDevelop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Runtime.Initialize (true);
			Console.WriteLine ("Done");
		}
	}
}
