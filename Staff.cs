using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff:Person
    {
        #region data members
        private string school;
        private double pay;
        #endregion
        #region properties
        public string School
        {
            get
            {
                return school;
            }
            set
            {
                school = value;
            }
        }
        public double Pay
        {
            get
            {
                return pay;
            }
            set
            {
                pay = value;
            }
        }
        #endregion
        #region constructor
        public Staff()
        {

        }
        public Staff(string nam, string adr,string sch, double pa):base(nam,adr)
        {
            School = sch;
            Pay = pa;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return base.ToString() + $"\nSchool: {School} \nPay: {Pay}";
        }
        #endregion
    }
}
