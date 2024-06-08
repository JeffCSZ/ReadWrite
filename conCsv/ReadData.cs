using System;
namespace conCsv
{

    public class ReadData
	{

        public List<string> employees { get; set; } = new List<string>();


        public void ReadALlData()
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


        }










    }
}

