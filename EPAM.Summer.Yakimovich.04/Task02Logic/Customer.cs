using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02Logic
{
    public class Customer
    {
        private string name;
        private decimal revenue;
        private string contactPhone;
        
        public string Name { get; set; }
        public decimal Revenue { get; set; }
        public string ContactPhone { get; set; }

        public string Format(string format)
        {
            CustomerFormatProvider formatProvider = new CustomerFormatProvider();
            format = "{0:" + format + "}";
            return string.Format(formatProvider, format, this);
        }
    }
}
