using ConsoleFile_ReadWrite;
using System.Buffers;


class Program
{

	public static void Main()
	{
		var c = new FileIO();
		var str = c.ReadData("TestData.csv");
		Console.WriteLine(str);

		c.WriteData("MyTestData.csv", str);
		Console.ReadLine();

		//var str2 = FileStaticIO.ReadData("TestData.csv");
  //      Console.WriteLine(str2);
  //      Console.ReadLine();

	}

}

