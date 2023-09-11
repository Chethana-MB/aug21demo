using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarydemo
{
    class customer
    {
        public int CustomerId { set; get; }
        public string CustomerName { set; get; }
    }

    class Program
    {
        
  
        static void Main(string[] args)
        {
            Dictionary<int, string> dicobj = new Dictionary<int, string>();
            Console.WriteLine("\n enter the elements in dictionary...");
            int counter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("enter key:");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter value:");
                string value = Console.ReadLine();
                dicobj.Add(key, value);
            }
            Console.WriteLine("\n printing the dictionary..");
            foreach(KeyValuePair<int,string>pair in dicobj)
            {
                Console.WriteLine("{0}--{1}",pair.Key,pair.Value);
            }
            Console.WriteLine("which key is having largest length value..");
            Console.WriteLine("{0}", dicobj.Values.Max());
            Dictionary<double, customer> dicofcustomers = new Dictionary<double, customer>()
            {
                {101.1,new customer(){CustomerId=101,CustomerName="kumar" } },
                {101.2,new customer(){CustomerId=102,CustomerName="suta"} }
};
            Console.WriteLine("\n printing customer dictionary"); 
            foreach(var customer in dicofcustomers)
            {
                Console.WriteLine("{0}:-->{1},{2}",
                    customer.Key,
                    customer.Value.CustomerId, customer.Value.CustomerName);
                    
            }
            Console.ReadLine();
        }
    }
}
