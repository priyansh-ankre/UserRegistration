﻿using System;
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

        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool validLastName(string lname)
        {
            if (Regex.IsMatch(lname, LAST_NAME_REGEX))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string EMAIL_REGEX1 = "^[a-z0-9]+([._+-][0-9a-z]+)@+[a-z0-9]+.[a-z]{2,4}([.][a-z]{2}$)";
        public static string EMAIL_REGEX2 = "^[a-z0-9]+([._+-][0-9a-z]+)@+[a-z0-9]+.[a-z]{2,4}$";
        public static string EMAIL_REGEX3 = "(^[a-z0-9]+)@+[a-z0-9]+.[a-z]{2,4}([.][a-z]{2}$)";
        public static string EMAIL_REGEX4 = "(^[a-z0-9]+)@+[a-z0-9]+.[a-z]{2,4}$";

        public bool validateEmail(string email)
        {
            if(Regex.IsMatch(email,EMAIL_REGEX1) || Regex.IsMatch(email, EMAIL_REGEX2) || Regex.IsMatch(email, EMAIL_REGEX3) || Regex.IsMatch(email, EMAIL_REGEX4))
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