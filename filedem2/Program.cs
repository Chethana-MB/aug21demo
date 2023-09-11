using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filedem2 {  
    class Program
{
    public static void WriteData()
    {
        FileStream fs = new FileStream
            (@"C:\Users\student\source\repos\aug21demo\filedem2\f2.txt",
            FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        Console.WriteLine("enter some string to write inside the file");
        string str = Console.ReadLine();
        sw.Write(str);
        sw.Flush();
        sw.Close();
        fs.Close();
    }
    public static void ReadData()
    {
            FileStream fs = new FileStream(@"f2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(4fffffff,SeekOrigin.Begin);
            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();

            }
    }
    static void Main(string[] args)
    {
       // WriteData();
       ReadData();

    }
}
}




