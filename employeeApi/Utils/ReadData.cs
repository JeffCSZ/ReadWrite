﻿using System;
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

}











