using ConsoleFile_ReadWrite;
using System.Buffers;


class Program
{

	public static void Main()
	{
		//var c = new FileIO();
		//var str = c.ReadData("TestData.csv");
		//Console.WriteLine(str);

		//c.WriteData("MyTestData.csv", str);
		//Console.ReadLine();

		//var str2 = FileStaticIO.ReadData("TestData.csv");
		//      Console.WriteLine(str2);
		//      Console.ReadLine();


		var c = new FileIO();
		//c.ReadWriteFile("TestData.csv", @"C:\Users\tc\Test.csv");
		var depts = c.GetDepartments("TestData.csv");  //IEnum
		//for (int i = 0; i<depts.Count; i++) {
		foreach (var dept in depts) 
		{
			Console.WriteLine(dept);
		}
		Console.WriteLine("Done");
		Console.ReadLine();
	}

}

