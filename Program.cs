namespace CSCI2910_Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileIO();
        }

        public static void FileIO()
        {
            //var rows = 1;

            using (StreamReader sr = new StreamReader(FileRoot.Root + @"\data.csv"))
            {
                try
                {
                    // skip first line
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string pipeLine = line.Replace(",", "|");
                        string[] elements = line.Split(",");
                        Write(pipeLine);
                                                
                        for (int i = 0; i < elements.Length; i++)
                        {
                            elements[i] = elements[i].Replace("\"", "");
                        }

                        Person person = new Person(elements[0], elements[1], elements[3], elements[8]);
                        Console.WriteLine(person.ToString());
                        //rows++;
                    }

                    //Console.WriteLine(rows);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static void Write(string input)
        {
            using (StreamWriter sw = new StreamWriter(FileRoot.Root + @"\data.psv", true))
            {
                try
                {
                    sw.WriteLine(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

    }
}
