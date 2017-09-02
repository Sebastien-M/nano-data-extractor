using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace nanoscope.FileReader
{
    public class Variables
    {
        public string extract_num_rev (string num)
        {
            Regex regex = new Regex("([0-9]+[.0-9]*)");
            Match match = regex.Match(num);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            return match.Value;
        }
    }
}
