using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationApp
{
    class UserRegistration
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool validFirstName(string fname)
        {
            if (Regex.IsMatch(fname, FIRST_NAME_REGEX))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
