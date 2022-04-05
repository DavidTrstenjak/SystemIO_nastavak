using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace System_IO
{
    internal class streamPisac
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišiite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Upišiite ¸prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(@"c:\prviDir\mojaDatoteka.txt");

            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();

            

            StreamReader sr = new StreamReader(@"c:\prviDir\mojaDatoteka.txt");

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }
    }
}
