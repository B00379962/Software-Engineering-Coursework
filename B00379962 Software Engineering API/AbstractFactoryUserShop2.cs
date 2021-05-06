using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManager
{
    public class UserShop2 : IUser
    {
        public List<string> Users()
        {
            return new List<string> {"Mark McMurray", "Jordan Smyth"};
        }
    }
}
