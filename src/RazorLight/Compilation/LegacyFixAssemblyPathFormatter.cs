using System;
using System.Reflection;

namespace RazorLight.Compilation
{
	public class LegacyFixAssemblyPathFormatter : IAssemblyPathFormatter
	{
		public string GetAssemblyPath(Assembly assembly)
		{
			return assembly.Location;
			//UriBuilder uriBuilder = new UriBuilder(codeBase);
			//string assemblyDirectory = Uri.UnescapeDataString(uriBuilder.Path + uriBuilder.Fragment);
		}
	}
}
