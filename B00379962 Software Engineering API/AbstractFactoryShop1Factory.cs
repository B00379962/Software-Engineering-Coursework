using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManager
{
    public class Shop1Factory : UserFactory
    {
        public override IUser GetUser(string usertype)
        {
            if (usertype.Equals("Adm"))
                return new AdminUserShop1();
            else if (usertype.Equals("Barb"))
                return new BarberUserShop1();
            else if (usertype.Equals("User"))
                return new UserShop1();
            else
                return null;
        }
    }
}
