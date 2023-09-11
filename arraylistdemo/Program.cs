using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylistdemo
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayList objlist = new ArrayList();
            objlist.Add(1);
            objlist.Add("ravi");
            objlist.Add('A');
            objlist.Add(true);
            objlist.Add(DateTime.Now);
            Console.WriteLine("\n the number of elements in arraylist " + objlist.Count);
            foreach(var ele in objlist)
            {
                Console.WriteLine(ele);

            }
            string[] names = new string[3] { "chethana", "sahana", "priya" };
            objlist.AddRange(names);
            Console.WriteLine("\n the number of elements in arraylist " + objlist.Count);
            foreach(var ele in objlist)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("the capacity of the arraylist " + objlist.Capacity);
            objlist.Insert(0, "abc");
            objlist.RemoveAt(3);
            objlist.Reverse();
            Console.WriteLine("\n the no of elements in arraylist " + objlist.Count);
            foreach( var ele in objlist)
            {
                Console.WriteLine(ele);
            }
            Console.ReadLine();


        }
    }
}
