using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesApp
{
    internal class Customer
    {
        public string Name{ get; set; }
        public string Address{ get; set; }
        public string contactNumber { get; set; }

        public Customer()
        {
            Name = "DefaultName";
            Address = "No Address";
            contactNumber = "No ContactNumber";
        }

        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            contactNumber = contactNumber;
        }

        public Customer(string name)
        {
            Name=name;
        }

        public void SetDetails(string name, string address, string contactNumber = "55991259612")
        {
            Name = name;
            Address = address; 
            contactNumber = contactNumber;
        }

    }
}
