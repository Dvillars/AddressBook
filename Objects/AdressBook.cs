using System.Collections.Generic;

namespace AddressBook.Objects
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
            SetCounter();
            SetId();
            _instances.Add(this);
        }

        public void SetName(string newName)
        {
          _name = newName;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetPhoneNumber(string newPhoneNumber)
        {
          _phoneNumber = newPhoneNumber;
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public void SetAddress(string newAddress)
        {
          _address = newAddress;
        }
        public string GetAddress()
        {
            return _address;
        }

        public static List<Contact> ContactList()
        {
            _instances.TrimExcess();
            return _instances;
        }

        public void SetCounter()
        {
          _counter++;
        }
        public static int GetCounter()
        {
            return _counter;
        }

        public void SetId()
        {
          _id = _counter;
        }
        public int GetId()
        {
            return _id;
        }

        public static void DeleteContact(int input)
        {
            _instances.RemoveAt(input-1);
            ResetAllIds();
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Contact Find(int Id)
        {
            ResetAllIds();
            return _instances[Id-1];
        }
        public static void ResetAllIds()
        {
            _instances.TrimExcess();
            _counter = 1;
            foreach(Contact contact in _instances)
            {
                contact.SetId();
                _counter++;
            }
        }
    }
}
