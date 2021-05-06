using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
