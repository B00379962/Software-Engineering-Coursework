

namespace DataAccessManager
{
    public class Shop2Factory : UserFactory
    {
        public override IUser GetUser(string usertype)
        {
            if (usertype.Equals("Adm"))
                return new AdminUserShop2();
            else if (usertype.Equals("Barb"))
                return new BarberUserShop2();
            else if (usertype.Equals("User"))
                return new UserShop2();
            else
                return null;
        }
    }
}
