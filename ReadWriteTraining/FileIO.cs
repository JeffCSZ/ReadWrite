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
			var data = fs.ReadToEnd();
			fs.Close();
			fs.Dispose();
			return data;

			//using var fs2 = File.Open(path, FileMode.Open);
			//var b = new Byte[fs2.Length];
			//fs2.Read(b, 0, b.Length);
			//var str = UTF8Encoding.UTF8.GetString(b);
			//return str;
		}

		public void WriteData(string path, string data)
		{
			using var fs = new StreamWriter(path);
			fs.Write(data, 0, data.Length);
			fs.Close();

			using var fs2 = File.Open(path, FileMode.Open);
			var b = new Byte[fs2.Length];
			fs2.Write(b, 0, b.Length);

		}
	}
}
