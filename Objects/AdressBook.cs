using System.Collections.Generic;

namespace AdressBook.Objects
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _address;
        private static List<Contact> _instances = new List<Contact> {};
        private static int _counter = 0;

        public Contact(string Name, string PhoneNumber, string Address)
        {
          _name = Name;
          _phoneNumber = PhoneNumber;
          _address = Address;
          _instances.Add(this);
          _counter++;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public string GetAddress()
        {
            return _address;
        }

        public static List<Contact> ContactList()
        {
            return _instances;
        }

        public static int GetCounter()
        {
            return _counter;
        }
    }
}
