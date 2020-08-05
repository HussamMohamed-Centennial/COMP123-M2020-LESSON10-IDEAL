using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_LESSON10_IDEAL
{
    public class Contact
    {
        // Public Prop
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }


        // Constructor
        public Contact(string firstName ="", string lastName="", string emailAddress ="", string contactNumber="")
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
        }
    }
}
