using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string ten {  get; set; }
        public string gioiTinh { get; set; }
        public DateTime dob {  get; set; }
        public string diaChi { get; set; }
        public string phone {  get; set; }
        public EmployeeDTO(int id, string ten, string gioiTinh,DateTime dob, string diaChi, string phone)
        {
            Id = id;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.dob = dob;
            this.diaChi = diaChi;
            this.phone = phone;
        }
    }
}
