using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL_proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\SHYAM SUNDER\Desktop\Proj1\SL_project1\data.txt";
            string line;

            //pass file path to stramreader class
            StreamReader sr = new StreamReader(file);

            //Read 1st line of file
            line = sr.ReadLine();

            //read file line-by-line
            while (line != null)
            {

                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }

            //closing the file
            sr.Close();
            Console.ReadLine();
        }
    }
}
