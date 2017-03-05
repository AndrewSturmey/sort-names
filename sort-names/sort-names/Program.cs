using System;
using System.IO;
using System.Collections.Generic;

namespace sort_names
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create a list to put the string pairs into
            var list = new List<string>();            
            try
            {  //loop through the text file and read each line in turn 
                foreach (string line in File.ReadLines(args[0]))
                {
                    //add it to the dictionary as a pair
                    list.Add(line);
                    
                }
                //and now we sort the list...
                list.Sort();
                //and here we output it to the console
                foreach (var pair in list)
                {
                    Console.WriteLine(pair);
                }
                //and this is where we want the sorted list to be stored
                //string startFile = args[0];
                string path = @"c://Users/Andrew/Source/Repos/sort-names/sorted-names.txt" ;

                // first check to see if the output file exists
                if (!File.Exists(path))
                {
                    //If not, then create it
                    File.WriteAllText(path, "");
                    
                }
                else
                {
                    //if it does exist append the sorted list
                    foreach (var pair in list)
                    {
                        File.AppendAllText(path, pair + Environment.NewLine);
                    }
                }
                //Console.WriteLine(path, startFile);
                Console.WriteLine("Finished: created sorted-names.txt");


            }
            catch (Exception e)
            {
                Console.WriteLine("the file could not be read");
                Console.WriteLine(e.Message);

            }
        }
    }
}
