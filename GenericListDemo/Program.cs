using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    class Customer
    {
        public int CustomerId { set; get; }
        public string CustomerName { set; get; }

        public static List<Customer> retrive()
        {
            List<Customer> clist = new List<Customer>();
            clist.Add(new Customer { CustomerId = 101, CustomerName = "chethana" });
            clist.Add(new Customer { CustomerId = 102, CustomerName = "sahana" });
            clist.Add(new Customer { CustomerId = 103, CustomerName = "priya" });
            return clist;


        }
        public static Customer findcustomer(List<Customer> clist, int custid)
        {
            Customer customerfound = null;
            foreach (Customer c in clist)
            {
                if (c.CustomerId == custid)
                {
                    customerfound = c;
                    break;
                }
            }
            return customerfound;
        }
        public static void updatecustomer(List<Customer> clist, int custid)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerId == custid)
                {
                    Console.WriteLine("\n enter new name :");
                    string name = Console.ReadLine();
                    clist[i].CustomerName = name;
                }

            }
        }
        public static void deletecustomer(List<Customer> clist, int custid)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerId == custid)
                {
                    clist.RemoveAt(i);
                }
            }
        }



        internal class Program
        {
            static void Main(string[] args)
            {
                List<int> numbers = new List<int>() { 12, 23, 45, 66, 77, 89, 19 };
                numbers.Sort();
                numbers.Add(12);
                Console.WriteLine("the generic list capacity: " + numbers.Capacity + " is having count:" + numbers.Count);
                foreach (int num in numbers)
                {
                    Console.Write("{0,5}", num);

                }
                List<Customer> clist1 = Customer.retrive();
                Console.WriteLine("\n display customer");
                foreach (Customer c in clist1)
                {
                    Console.WriteLine("{0}--{1}", c.CustomerId, c.CustomerName);
                }
                Console.WriteLine("\n enter the customer id to find her name:");
                int custid1 = Convert.ToInt16(Console.ReadLine());
                Customer custfound = Customer.findcustomer(clist1, custid1);
                if (custfound != null)
                {
                    Console.WriteLine("the customer with id {0} is having name {1}",
                        custfound.CustomerId, custfound.CustomerName);
                }
                Console.WriteLine("\n enter the customer to be updated...");
                int custid2 = Convert.ToInt16( Console.ReadLine());
                Customer.updatecustomer(clist1, custid2);
                Console.WriteLine("\n updatedcustomer...checking");
                foreach(Customer c in clist1)
                {
                    Console.WriteLine("{0}--{1}", c.CustomerId, c.CustomerName);
                }

                Console.WriteLine("\n enter the customer to be deleted...");
                int custid3 = Convert.ToInt16(Console.ReadLine());
                Customer.deletecustomer(clist1, custid3);
                Console.WriteLine("\n updatedcustomer...checking");
                foreach (Customer c in clist1)
                {
                    Console.WriteLine("{0}--{1}", c.CustomerId, c.CustomerName);
                }
                Console.ReadLine();
            }
        }
    }
}


