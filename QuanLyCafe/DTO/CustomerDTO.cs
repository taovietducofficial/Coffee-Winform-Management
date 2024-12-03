using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class CustomerDTO
    {
        public string phone { get; set; }
        public string name { get ; set; }
        public string address { get; set; }
        public CustomerDTO(string phone, string name, string address)
        {
            this.phone = phone;
            this.name = name;
            this.address = address;
        }
    }
}
