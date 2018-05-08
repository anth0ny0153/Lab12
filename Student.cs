using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student:Person
    {
        #region data members
        private int year;
        private double fee;
        #endregion
        #region properties
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }

        #endregion
        #region constructor
        public Student()
        {

        }
        public Student(string nam, string adr,int yr, double fe):base(nam,adr)
        {
            Year = yr;
            Fee = fe;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return base.ToString() + $"\nYear: {Year} \nFee: {Fee}";
        }
        #endregion
    }
}
