using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessManager;
using Xunit;

namespace APITests
{
    public class AbstractFactoryTests
    {

        IUser user = null;
        UserFactory userFactory = null;
        List<string> users = null;


        [Fact]
        public void CheckShop1Exists()
        {
            string shop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");
            if (userFactory != null)
            {
                shop1 = "Y";
            }

            Assert.Equal("Y", shop1);
        }

        [Fact]
        public void CheckShop2Exists()
        {
            string shop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");
            if (userFactory != null)
            {
                shop2 = "Y";
            }

            Assert.Equal("Y", shop2);
        }


        [Fact]
        public void CheckShop1AdminGroupExists()
        {
            string usergrpshop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");

            user = userFactory.GetUser("Adm");
            if (user != null)
            {
                usergrpshop1 = "Y";
            }

            Assert.Equal("Y", usergrpshop1);
        }

        [Fact]
        public void CheckShop2AdminGroupExists()
        {
            string usergrpshop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");

            user = userFactory.GetUser("Adm");
            if (user != null)
            {
                usergrpshop2 = "Y";
            }

            Assert.Equal("Y", usergrpshop2);
        }

        [Fact]
        public void CheckShop1BarbersGroupExist()
        {
            string barbergrpshop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");

            user = userFactory.GetUser("Barb");
            if (user != null)
            {
                barbergrpshop1 = "Y";
            }

            Assert.Equal("Y", barbergrpshop1);
        }



        [Fact]
        public void CheckShop2BarbersGroupExist()
        {
            string barbergrpshop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");



            user = userFactory.GetUser("Barb");
            if (user != null)
            {
                barbergrpshop2 = "Y";
            }

            Assert.Equal("Y", barbergrpshop2);
        }


        [Fact]
        public void CheckShop1UserGroupExist()
        {
            string usergrpshop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");

            user = userFactory.GetUser("User");
            if (user != null)
            {
                usergrpshop1 = "Y";
            }

            Assert.Equal("Y", usergrpshop1);
        }


        [Fact]
        public void CheckShop2UserGroupExist()
        {
            string usergrpshop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");

            user = userFactory.GetUser("User");
            if (user != null)
            {
                usergrpshop2 = "Y";
            }

            Assert.Equal("Y", usergrpshop2);
        }


        [Fact]
        public void CheckShop1AdminPersonExists()
        {
            string adminusershop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");

            user = userFactory.GetUser("Adm");

            users = user.Users();
            if(user != null)
            {
                adminusershop1 = "Y";
            }
            Assert.Equal("Y", adminusershop1);
        }

        [Fact]
        public void CheckShop2AdminPersonExists()
        {
            string adminusershop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");

            user = userFactory.GetUser("Adm");

            users = user.Users();
            if (user != null)
            {
                adminusershop2 = "Y";
            }
            Assert.Equal("Y", adminusershop2);
        }

        [Fact]
        public void CheckShop1BarberPersonExists()
        {
            string barberusershop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");

            user = userFactory.GetUser("Barb");

            users = user.Users();
            if (user != null)
            {
                barberusershop1 = "Y";
            }
            Assert.Equal("Y", barberusershop1);
        }

        [Fact]
        public void CheckShop2BarberPersonExists()
        {
            string barberusershop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");

            user = userFactory.GetUser("Barb");

            users = user.Users();
            if (user != null)
            {
                barberusershop2 = "Y";
            }
            Assert.Equal("Y", barberusershop2);
        }


        [Fact]
        public void CheckShop1UserPersonExists()
        {
            string usershop1 = "N";
            userFactory = UserFactory.CreateUserFactory("shop1");

            user = userFactory.GetUser("User");

            users = user.Users();
            if (user != null)
            {
                usershop1 = "Y";
            }
            Assert.Equal("Y", usershop1);
        }

        [Fact]
        public void CheckShop2UserPersonExists()
        {
            string usershop2 = "N";
            userFactory = UserFactory.CreateUserFactory("shop2");

            user = userFactory.GetUser("User");

            users = user.Users();
            if (user != null)
            {
                usershop2 = "Y";
            }
            Assert.Equal("Y", usershop2);
        }

    }
}
