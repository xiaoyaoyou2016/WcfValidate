﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;


namespace WCFServer
{
    public class UserValidate : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "fox" || password != "123456")
            {
                throw new SecurityTokenException("Unknown Username or Password");
            }
        }
    }
}
