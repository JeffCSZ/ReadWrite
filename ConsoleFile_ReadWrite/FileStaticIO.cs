using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFile_ReadWrite
{
	public static class FileStaticIO
	{
		public static string ReadData(string fileName)
		{
			using var sr = new StreamReader(fileName);
			var data = sr.ReadToEnd();
			sr.Close();
			//Console.WriteLine(data);
			return data;

		}
	}
}
