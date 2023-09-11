using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filedem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\Mysuru");
            DirectoryInfo[] directories = info.GetDirectories("D*",
                searchOption: SearchOption.AllDirectories);
            foreach (DirectoryInfo directory in directories)
            {
                
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    string extension = Path.GetExtension(file.FullName);
                    if (extension.Equals(".txt"))
                    {
                        Console.WriteLine("{0}--{1}", directory.Name, file.Name);
                    }

                }

            }
            Console.ReadLine();

        }
    }
}

