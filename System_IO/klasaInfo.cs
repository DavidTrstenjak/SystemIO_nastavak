using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace System_IO
{
    internal class klasaInfo
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo (@"c:\");
            Console.WriteLine("\n Poddirektoriji: ");

            foreach (DirectoryInfo diInfo in di.GetDirectories())
            {
                Console.WriteLine("{0}\t{1}\t{2}", diInfo.Name, diInfo.CreationTime, diInfo.LastAccessTime);
            }

            foreach (DirectoryInfo fiInfo in di.GetDirectories())
            {
                Console.WriteLine("{0}\t{1}\t{2}", fiInfo.Name, fiInfo.CreationTime, fiInfo.LastAccessTime);
            }

        }
    }
}
