

namespace DataAccessManager
{
    public abstract class UserFactory
    {
        public abstract IUser GetUser(string shop);

        public static UserFactory CreateUserFactory(string shop)
        {
            if (shop.Equals("shop1"))
                return new Shop1Factory();
            else if (shop.Equals("shop2"))
                return new Shop2Factory();
            else
                return null;
        }
    }
}
