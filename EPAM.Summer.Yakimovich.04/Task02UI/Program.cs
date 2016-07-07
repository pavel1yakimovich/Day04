using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02Logic;

namespace Task02UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.ContactPhone = "123214234";
            c.Revenue = 1234.65M;
            c.Name = "Name";

            Console.WriteLine(c.Format(""));
            Console.ReadLine();
        }
    }
}
