using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Mekele
{
    class Validation
    {
        public void CheckCustomerName(string cust_first_name, string cust_last_name)
        {
            if (cust_first_name.Length > 10 || cust_last_name.Length > 10)
                throw new Exception("Name should be within 10 characters.");
            else if (cust_first_name == "" || cust_last_name == "")
                throw new Exception("Name is required.");
        }
    }
}
