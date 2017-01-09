using System;
using System.Collections.Generic;
using System.Text;

namespace XFSX_Test_1
{
    class Functions
    {
        public bool IsNullOrEmpty(string str)
        {
            if (str == null || str.Equals(""))
                return true;
            return false;
        }
        
    }
    class Constants
    {
        public static string RESTUriBase = "http://dcgdatabaseapi.azurewebsites.net/api{0}";
    }
}
