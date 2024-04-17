using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelier.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }

        public int Level { get; set; }
        public string Note { get; set; }

        public List<Customers> ListCustomer()
        {
            List<Customers> ListCustomer = new List<Customers>();
            
            ListCustomer.Add(new Customers()
            {
                FirstName = "Thu",
                LastName = "Doan",
                Email = "thudoan123@gmail.com",
                Phone = "0978562143",
                Address = "Cam Pha, Quang Ninh, Vietnam",
                IdentityCard = "012345678965",
                Password = "$2y$10$yTVfb5kClxTbNXyreuc2yuOfZabVq.hb78xxSUBx71EklyIOuncPe",
                CreateDate = DateTime.Now,
                Status = 1,
                Level = 1,
                Note = ""
            });


            ListCustomer.Add(new Customers()
            {
                FirstName = "An",
                LastName = "Nguyen",
                Email = "ann2k@gmail.com",
                Phone = "0985721746",
                Address = "Ha Nam, Vietnam",
                IdentityCard = "0163875672969",
                Password = "$2y$10$yTVfb5kClxTbNXyreuc2yuOfZabVq.hb78xxSUBx71EklyIOuncPe",
                CreateDate = DateTime.Now,
                Status = 1,
                Level = 2,
                Note = ""
            });

            ListCustomer.Add(new Customers()
            {
                FirstName = "Hoa",
                LastName = "Dinh",
                Email = "hoapt97@gmail.com",
                Phone = "0985621743",
                Address = "Phu Tho, Vietnam",
                IdentityCard = "0153845672869",
                Password = "$2y$10$yTVfb5kClxTbNXyreuc2yuOfZabVq.hb78xxSUBx71EklyIOuncPe",
                CreateDate = DateTime.Now,
                Status = 1,
                Level = 2,
                Note = ""
            });

            return ListCustomer;

        }
    }
}