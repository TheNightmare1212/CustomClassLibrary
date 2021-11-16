using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassLibrary
{
    public class Customer: Person
    {
       
        public string Phone { get; set; }

        
        public string Email { get; set; }
        
        public List<Address> Addresses { get;private set; }

        public decimal  TotalPurchaseAmount { get;private set; }
        
        public List<string> Notes { get; private set; }
       
        
        public Customer(string firstname, string lastname, string phone, string email, List<Address> addresses, decimal totalAmount,List<string> notes) : base(firstname, lastname)
        {
            Phone = phone;
            Email = email;
            Addresses = addresses;
            TotalPurchaseAmount = totalAmount;
            Notes = notes;
        }
    }
}
