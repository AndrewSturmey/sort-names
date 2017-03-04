using System;
using System.IO;

namespace sort_names
{
    class Program
    {
        public static void Main()
        {
            try
            {  //open the text file with a streamreader
                using (StreamReader sr = new StreamReader("C://Users/Andrew/Source/Repos/names.txt"))
                {
                    // write the stream to string and write to the console
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("the file could not be read");
                Console.WriteLine(e.Message);

            }
        }
    }
}
