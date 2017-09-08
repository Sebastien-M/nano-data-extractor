using System;
using System.IO;
using System.Collections;
using System.Linq;
using nanoscope.FileReader;

namespace nanoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.test();
        }

        public static void test(){
            string[] fileArray = Directory.GetFiles("Data/", "*", searchOption: SearchOption.AllDirectories);
            // Console.WriteLine(fileArray);
            ReadFile readfile = new ReadFile();
            for (int i = 0; i < fileArray.Length; i++)
            {
                // Console.WriteLine(fileArray[i]);
            }

            ReadFile.headLect("wt-lame2-zone1.100");
        }

        // static string Affichage()
        // {
        //     return "Hello World!";
        // }

    }
}

