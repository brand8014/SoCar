using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class LoginData : EntityData<Login>
    {
        public Login Get(string userName, string password)
        {
            var context = CreateContext();

            var query = from x in context.Logins
                        where x.UserName == userName && x.Password == password
                        select x;

            return query.FirstOrDefault();
        }
    }
}
