using System.Collections.Generic;


namespace DataAccessManager
{
    public class BarberUserShop1 : IUser
    {
        public List<string> Users()
        {
            return new List<string> { "Davie Walker", "Robbie Murphy", "Barry Smith" };
        }
    }
}
