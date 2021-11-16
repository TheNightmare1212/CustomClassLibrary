using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassLibrary
{
    public class Address
    {
        public string Line { get; private set; }
     
        public string Line2 { get; set; }
        public AddrType Type { get; private set; }
      
        public string City { get; private set; }
       
        public string PostalCode { get;private set; }
       
        public string State { get; private set; }
      
        public string Country { get;private set; }
        public Address(string line, string line2, AddrType type, string city, string postalcode, string state, string country)
        {
            Line = line;
            Line2 = line2;
            Type = type;
            City = city;
            PostalCode = postalcode;
            State = state;
            Country = country;
        }
    }
    public enum AddrType
    {
        Shipping,
        Billing
    }
}
