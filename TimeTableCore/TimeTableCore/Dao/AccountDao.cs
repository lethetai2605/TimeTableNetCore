using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTableCore.Models;
namespace TimeTableCore.Dao
{
    public class AccountDao
    {
        TimeTableNewContext db = null;
        public AccountDao()
        {
            db = new TimeTableNewContext();
        }

        public Account GetAccountByUserName(string userName)
        {
            return db.Account.SingleOrDefault(x => x.UserName == userName);
        }
        public bool Login(string userName,string passWord)
        {
            var result = db.Account.Count(x => x.UserName == userName && x.PassWord == passWord);
            if(result > 0 )
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
