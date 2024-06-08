using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleReadDate
{
	public class Reader
	{

		
	   
		public string ReadData()
		{
			//using var sr = new StreamReader("TestData.csv");
			//var data=sr.ReadToEnd();
			//Console.WriteLine(data);
			//return data;

			using var fs=File.Open("TestData.csv", FileMode.Open);
			var b = new byte[fs.Length];
			fs.Read(b, 0, b.Length);


			//var b = new byte[fs.Length];
			//convert b to string
			var s=UTF8Encoding.UTF8.GetString(b);
            Console.WriteLine(	s);
			return s;



        }


	}
}
