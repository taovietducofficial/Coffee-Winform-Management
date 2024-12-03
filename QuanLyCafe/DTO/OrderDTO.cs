using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class OrderDTO
    {
        private int Id { get; set; }
        private int idMenu { get; set; }
        private string idBill {  get; set; }
        private int number { get; set; }
        public OrderDTO(int id, int idMenu, string idBill, int number)
        {
            Id = id;
            this.idMenu = idMenu;
            this.idBill = idBill;
            this.number = number;
        }
        public int getId(int id)
        {
            return id;
        }
        public int getIdMenu()
        {
            return idMenu;
        }
        public string getIdBill()
        {
            return idBill;
        }
        public int getNumber()
        {
            return number;
        }
    }
}
