using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataAccessManager;
using AssetReservation;

namespace APITests
{
    public class InstantiatedAppointmentsTests
    {
        [Fact]
        public void CheckListAdditioOneItem()
        {
            List<InstantiatedApps> apps = new List<InstantiatedApps>();
            apps.Add(new InstantiatedApps(1, 100, "Test User", "Y", "Test Shop"));

            var counts = apps.Count();

            Assert.True(counts == 1);
        }

        [Fact]
        public void CheckListAdditioMultipleItem()
        {
            List<InstantiatedApps> apps = new List<InstantiatedApps>();
            apps.Add(new InstantiatedApps(1, 100, "Test User", "Y", "Test Shop"));
            apps.Add(new InstantiatedApps(2, 100, "Test User", "Y", "Test Shop"));
            apps.Add(new InstantiatedApps(3, 100, "Test User", "Y", "Test Shop"));
            apps.Add(new InstantiatedApps(4, 100, "Test User", "Y", "Test Shop"));

            var counts = apps.Count();

            Assert.True(counts == 4);
        }

        [Fact]
        public void InstantiateAppointments()
        {

            var uninstantiatedId = 1;
            var uninstantiatedBarberId = 2;
            var uninstanatiedBarber = "Test Barber";
            var uninstantiatedBooked = "Y";
            var uninstantiatedShop = "Test Shop";

            InstantiatedApps i = new InstantiatedApps(uninstantiatedId, uninstantiatedBarberId, uninstanatiedBarber, uninstantiatedBooked, uninstantiatedShop);

           

            var instantiatedId = i.Id;
            var instantiatedBarberId = i.BarberID;
            var instantiatedBarber = i.Barber;
            var instantiatedBooked = i.Booked;
            var instantiatedShop = i.Shop;
           

            Assert.Equal(uninstantiatedId, instantiatedId);
            Assert.Equal(uninstantiatedBarberId, instantiatedBarberId);
            Assert.Equal(uninstanatiedBarber, instantiatedBarber);
            Assert.Equal(uninstantiatedBooked, instantiatedBooked);
            Assert.Equal(uninstantiatedShop, instantiatedShop);
        }

        [Fact]
        public void InstantiateProducts()
        {

            var uninstantiatedName = "Test";
            var uninstantiatedAmmount = 1;
            var uninstanatiedProductId = 1;


            InstantiatedProducts p = new InstantiatedProducts(uninstantiatedName, uninstantiatedAmmount, uninstanatiedProductId);

            var instantiatedName = p.Name;
            var instantiatedAmount = p.amount;
            var instantiatedProductId = p.Prodid;


            Assert.Equal(uninstantiatedName, instantiatedName);
            Assert.Equal(uninstantiatedAmmount, instantiatedAmount);
            Assert.Equal(uninstanatiedProductId, instantiatedProductId);

        }
    }
}