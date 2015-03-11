using System;
using System.Linq;
using MonoDevelop.Core;
using MonoDevelop.Projects;
using System.IO;
using MonoDevelop.Core.ProgressMonitoring;

namespace TestMonoDevelop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Runtime.Initialize (true);
			foreach (var binding in LanguageBindingService.LanguageBindings)
				LoggingService.LogInfo ("Loaded Language Binding: {0}", binding.Language);
			var temp = Path.GetTempPath ();
			var s = CreateSolution (temp, "mdcore");
			Console.WriteLine ("Solution created at {0}", temp);
		}

		private static Solution CreateSolution (string dir, string name)
		{
			var solution = new Solution ();
			var slnFile = Path.Combine (dir, string.Format ("{0}.sln", name));
			solution.SetLocation (Path.GetDirectoryName (slnFile), Path.GetFileNameWithoutExtension (slnFile));
			solution.CreateDefaultConfigurations ();
			solution.Save (new NullProgressMonitor ());
			return solution;
		}
	}
}
