using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class BillDTO
    {
        private string billID {  get; set; }
        private int idEmployee {  get; set; }
        private DateTime dateCheck {  get; set; }
        private string phoneNumber { get; set; }
        public BillDTO(string billID, int idEmployee, DateTime dateCheck, string phoneNumber)
        {
            this.billID = billID;
            this.idEmployee = idEmployee;
            this.dateCheck = dateCheck;
            this.phoneNumber = phoneNumber;
        }
        public string getBillId() { return this.billID; }
        public int getEmployeeID() { return this.idEmployee; }
        public DateTime getDateCheck() { return this.dateCheck;}
        public string getPhoneNumber() { return this.phoneNumber;}
    }
}
