using System.Collections.Generic;

namespace AdressBook.Objects
{
    public class Contact
    {
        private static List<Contact> Contactlist = new List<Contact> {};

        private string _name;
        private string _phoneNumber;
        private string _address;

        public string GetName()
        {
          return _name;
        }
        public void SetName(string newName)
        {
          _name = newName;
        }

        public string GetPhoneNumber()
        {
          return _phoneNumber;
        }
        public void SetPhoneNumber(string newPhoneNumber)
        {
          _phoneNumber = newPhoneNumber;
        }

        public string GetAddress()
        {
          return _address;
        }
        public void SetAddress(string newAddress)
        {
          _address = newAddress;
        }

    }
}
