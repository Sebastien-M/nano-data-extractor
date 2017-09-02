using System;
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
            ReadFile readfile = new ReadFile();
            ReadFile.headLect("wt-lame2-zone1.100");
        }

        // static string Affichage()
        // {
        //     return "Hello World!";
        // }

    }
}

