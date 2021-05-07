using System.Collections.Generic;


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
