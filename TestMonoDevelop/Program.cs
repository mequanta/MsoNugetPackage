using System;
using System.Linq;
using MonoDevelop.Core;
using MonoDevelop.Projects;

namespace TestMonoDevelop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Runtime.Initialize (true);
			foreach (var binding in LanguageBindingService.LanguageBindings)
				LoggingService.LogInfo ("Loaded Language Binding: {0}", binding.Language);
			Console.WriteLine("Done.");
		}
	}
}
