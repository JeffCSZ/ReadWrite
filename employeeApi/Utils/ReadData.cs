using employeeApi.Models;
using System;
namespace employeeApi.Utils;


public class ReadData
{

	public List<string> employees { get; set; } = new();


	public ReadData ReadALlData()
	{

		int lineCount = 0;
		using (StreamReader file = new StreamReader("TestData.csv"))
		{
			while (!file.EndOfStream)
			{
				var line = file.ReadLine();
				if (lineCount > 1)
				{

					//store titles
					if (lineCount == 2)
					{
						//titles = line.Split(",");
						//Console.WriteLine(line);
					}
					else
					{
						var fields = line.Split(",");
						employees.Add(fields[2]);

					}


				}

				lineCount++;
			}

		}

		return this;
	}

	public ReadData ReadALlDataFromString(string str)
	{

		var lines = str.Split("\n");

		for (var i = 3; i < lines.Length; i++)
		{
			var fields = lines[i].Split(",");
			employees.Add(fields[2]);

		}
		//Console.WriteLine("ReadALlDataFromString");
		return this;
    }

	public List<string> DeptLocRegionState(string fileName)
	{
		using var fs = new StreamReader(fileName);
		var str = new List<string>();
		int count = 0;
		while (!fs.EndOfStream)
		{
			var line = fs.ReadLine();
			if (count >= 3)
			{
				var fields = line.Split(",");
				var str1 = fields[5].Replace("\"", "").TrimStart().TrimEnd();
                var str2 = fields[7].Replace("\"", "").TrimStart().TrimEnd();
                var str3 = fields[8].Replace("\"", "").TrimStart().TrimEnd();
                var str4 = fields[9].Replace("\"", "").TrimStart().TrimEnd();
				if (!str.Contains(str1))
				{
					str.Add(str1);
				}
				else if (!str.Contains(str2))
				{ str.Add(str2); }
				else if (!str.Contains(str3))
				{ str.Add(str3); }
				else if (str.Contains(str4))
				{ str.Add(str4); }
				else
				{
					continue;
				}
			}
			count++;
		}
		fs.Close();
		return str;
	}
}












