using System.Collections.Generic;


namespace DataAccessManager
{
    public class UserShop1 : IUser
    {
        public List<string> Users()
        {
            return new List<string> {"Danny Walls"};
        }
    }
}
