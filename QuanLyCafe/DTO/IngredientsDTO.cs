using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class IngredientsDTO
    {
        public int id {  get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int number { get; set; }
        public IngredientsDTO(int id,string name,float price, int number) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.number = number;
        }
    }
}
