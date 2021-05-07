using System.Collections.Generic;


namespace DataAccessManager
{
    public class BarberUserShop2 : IUser
    {
        public List<string> Users()
        {
            return new List<string> {"John McDonald"};
        }
    }
}
