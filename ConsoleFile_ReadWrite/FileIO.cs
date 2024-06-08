using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFile_ReadWrite
{
	public class FileIO
	{
		public string ReadData(string fileName)
		{
			//high level using StreamReader
			using (var sr = new StreamReader(fileName))  //old way of wrting
			{
				var data = sr.ReadToEnd();
				sr.Close();
				sr.Dispose();
				return data;

			}

			//using var sr = new StreamReader(fileName);
			//var data= sr.ReadToEnd();
			//sr.Close();
			//         //Console.WriteLine(data);
			//         return data;

			// low level using File
			//using var fs = File.OpenRead(fileName);
			//using var fs = File.Open(fileName, FileMode.Open);
			//var b = new byte[fs.Length];
			//fs.Read(b, 0, b.Length);
			////convert byte[] to string
			//var s = UTF8Encoding.UTF8.GetString(b);
			//return s;

		}

		public void ReadWriteFile(string readFileName, string writeFileName)
		{
			DeleteFile(writeFileName);
			var fs = new StreamReader(readFileName);
			while (!fs.EndOfStream)
			{
				var line = fs.ReadLine();
				WriteLine(writeFileName, line);
			}
			fs.Close();
		}

		//public void WriteData(string fileName, string data)
		//{
		//	// high level using StreamWriter 
		//	//using var fs = new StreamWriter(fileName);
		//	//fs.Write(data, 0, data.Length);
		//	////fs.WriteLine(data);
		//	//fs.Close();

		//	// low level using File
		//	var fs = File.Open(fileName, FileMode.Create);
		//	//Convert string to byte[]
		//	var b = UTF8Encoding.UTF8.GetBytes(data);
		//	fs.Write(b, 0, b.Length);
		//	fs.Close();


		//}

		public void WriteLine(string fileName, string line)
		{
			using var fs = new StreamWriter(fileName, true);
			fs.WriteLine(line);
			fs.Close();
		}

		public void DeleteFile(string fileName)
		{
			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}
		}

		public List<string> GetDepartments(string fileName)
		{
			using var fs = new StreamReader(fileName);
			var departments = new List<string>();
			int count = 0;
			while (!fs.EndOfStream)
			{
				var line = fs.ReadLine();
				if (count >= 3)
				{
					var fields = line.Split(",");
					var dept = fields[5].Replace("\"", "").TrimStart().TrimEnd();
					if (departments.Contains(dept))
					{
						continue;
					}
					else
					{
						departments.Add(dept);
					}
				}
				count++;
			}
			fs.Close();
			return departments;
		}
	}
}
