using System;
using System.ComponentModel.DataAnnotations;

namespace CustomClassLibrary
{
    public abstract class Person
    {
      
        public string FirstName { get;private set; }
        
    
        public string LastName { get;private set; }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
