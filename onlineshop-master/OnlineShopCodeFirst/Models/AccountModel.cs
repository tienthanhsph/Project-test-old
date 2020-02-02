﻿using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }
            
        public bool Login(string userName   , string password)
        {
            object[] sqlParams =  {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password)
            };

            var res = context.Database.SqlQuery<bool>("sp_Login @UserName, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
