using System;
using System.IO;
using System.Linq;
namespace nanoscope.FileReader
{
    public class ReadFile
    {

        public static void headTest(string filename)
        {
            string header_pos = null;
            int counter = 0;
            string line;
            string path = filename;
            string[] lines = File.ReadAllLines(path);
            string ligne = lines[0];
            int nblines = lines.Count() - 1;
            Console.WriteLine(value: "Nombre de lignes : " + nblines.ToString());

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(path: path);
            if (file.ReadLine() != "\\*Force file list")
            {
                Console.WriteLine(value: "This is not a nanoscoe file");
            }
            else
            {
                Console.WriteLine("This is a nanoscoe file");
            }
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
                    Console.WriteLine(header_pos);
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