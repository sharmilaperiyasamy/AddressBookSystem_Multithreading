using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_MultiThreading
{
    public class Book_Definition_Model
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone_no { get; set; }
        public string Email { get; set; }
        public string name { get; set; }
        public string Persontype { get; set; }
        public Book_Definition_Model(int personId, string firstName, string lastName, string address, string city, string state, int zip, string phone_no, string email, string name, string persontype)
        {
            this.PersonId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone_no = phone_no;
            this.Email = email;
            this.name = name;
            this.Persontype = persontype;
        }
    }
}
