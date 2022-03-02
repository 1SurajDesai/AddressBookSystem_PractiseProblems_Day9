using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContactsInAddressBook
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNo;
        public string Email;

        public void AddPerson()
        {
            
            Console.WriteLine("Enter a first name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter a last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter a address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter a city:");
            City = Console.ReadLine();
            Console.WriteLine("Enter a state:");
            State = Console.ReadLine();
            Console.WriteLine("Enter a zip code:");
            Zip = Console.ReadLine();
            Console.WriteLine("Enter a phone number:");
            PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter a email:");
            Email = Console.ReadLine();
            
            


        }
    }
}