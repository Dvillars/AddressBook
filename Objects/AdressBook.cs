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
        private int _id;

        public Contact(string Name, string PhoneNumber, string Address)
        {
          SetName(Name);
          SetPhoneNumber(PhoneNumber);
          SetAddress(Address);
          _instances.Add(this);
          SetCounter();
        }

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

        public static List<Contact> ContactList()
        {
            _instances.TrimExcess();
            return _instances;
        }

        public static int GetCounter()
        {
            return _counter;
        }
        public void SetCounter()
        {
            _counter++;
        }

        public int GetId()
        {
            return _id;
        }
        public void SetId()
        {
            _id = _counter;
        }

        public static void DeleteContact(int input)
        {
            _instances.RemoveAt(input);
        }
    }
}
