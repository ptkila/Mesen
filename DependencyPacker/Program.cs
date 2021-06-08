using System.IO;
using System.IO.Compression;

namespace DependencyPacker
{
   class Program
   {
	  static void Main(string[] args)
	  {
		 if (File.Exists("Dependencies.zip"))
		 {
			File.Delete("Dependencies.zip");
		 }
		 ZipFile.CreateFromDirectory("Dependencies", "Dependencies.zip");
	  }
   }
}
