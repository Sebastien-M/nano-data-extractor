using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nanoscope.FileReader
{
    public class ReadFile
    {


        public static void headLect(string filename)
        {
            Variables variables = new Variables();

            string header_pos = null;
            int counter = 0;
            string line;
            string path = filename;
            string[] lines = File.ReadAllLines(path);
            string ligne = lines[0];
            int nblines = lines.Count() - 1;
            Console.WriteLine(value: "Nombre de lignes : " + nblines.ToString());


            Dictionary<string, int> version = new Dictionary<string, int>
            {
                { "8.0", 0 },
                { "7.0", 0 },
                { "6.1", 0 }
            };

            Dictionary<string, string> header = new Dictionary<string, string>
            {};

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(path: path);
            if (file.ReadLine() != "\\*Force file list")
            {
                Console.WriteLine(value: "This is not a nanoscoe file");
            }
            else
            {

                while ((line = file.ReadLine()) != "\\*File list end")
                {
                    if (line == "\\*Force file list")
                    {
                        header_pos = "File Description";
                    }
                    else if (line == "\\*Equipment list")
                    {
                        header_pos = "Equipment list";
                    }
                    else if (line == "\\*Ciao scan list")
                    {
                        header_pos = "Scan list";
                    }
                    else if (line == "\\*Ciao force list")
                    {
                        header_pos = "Force list";
                    }
                    else if (line == "\\*Ciao image list")
                    {
                        header_pos = "Image list";
                    }
                    else if (line == "\\*Ciao force image lis")
                    {
                        header_pos = "Force image";
                    }
                    else if (header_pos == "File Description")
                    {
                        
                    }

                    counter++;
                }
                file.Close();
                Console.WriteLine(header_pos);

                // System.Console.WriteLine("There were {0} lines.", counter);
                // Suspend the screen.  
                // System.Console.ReadLine();
            }



        }
    }
}