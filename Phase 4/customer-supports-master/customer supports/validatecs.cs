using customer_supports.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace customer_supports
{
    public class validatecs
    {
        phase4Entities1 db = new phase4Entities1();
        public bool check()
        {
            bool ans = false;
            var found = db.userinfoes.ToList();
            if (found[0].userid==1 && found[0].email=="kannan@gmail.com")
            {
                ans = true; 
            }
            return ans;
        }
       
    }
}