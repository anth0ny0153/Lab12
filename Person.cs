using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        #region data members
        private string name;
        private string address;
        #endregion
        #region properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        #endregion
        #region constructor
        public Person()
        {

        }
        public Person(string nam,string adr)
        {
            Name = nam;
            Address = adr;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address}";
        }
        #endregion
    }
}
