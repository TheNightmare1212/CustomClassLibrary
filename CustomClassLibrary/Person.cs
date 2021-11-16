using System;
using System.ComponentModel.DataAnnotations;

namespace CustomClassLibrary
{
    public abstract class Person
    {
        [MaxChars(50)]
        public string FirstName { get;private set; }
        
        [RequiredString]
        [MaxChars(50)]
        public string LastName { get;private set; }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
