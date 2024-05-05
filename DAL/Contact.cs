using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Company { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Contact()
        {
            
        }
        public Contact(string name, string lastName, string phoneNumber, string? company, string? description)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Company = company;
            Description = description;
            CreationDate = DateTime.Now;
        }
    }
}
