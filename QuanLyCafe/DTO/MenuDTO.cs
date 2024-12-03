using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class MenuDTO
    {
        private int id { get; set; }
        private string nname { get; set; }
        private double price { get; set; }
        byte[] image { get; set; }
        public MenuDTO(int id, string name, double price, byte[] image)
        {
            this.id = id;
            this.nname = name;
            this.price = price;
            this.image = image;
        }
        public int Id { get { return id; } }
        public string Nname { get {  return nname; } }
        public double Price { get { return price; } }
        public byte[] Image { get { return image; } }
    }

}
