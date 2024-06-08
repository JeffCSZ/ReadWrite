using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteTraining
{
	public class FileIO
	{
		public string ReadData(string path)
		{
			using var fs = new StreamReader(path);
			fs.ReadToEnd();

		}
	}
}
