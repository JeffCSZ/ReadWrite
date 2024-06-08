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












