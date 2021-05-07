using System.Collections.Generic;
using System.Linq;
using Xunit;
using DataAccessManager;

namespace APITests
{
    public class InstantiatedAppointmentsTests
    {

        [Fact]
        public void CheckListAdditionOneItem()
        {
            // check 1 item is being added to the list with no external dependency 
            List<InstantiatedApps> apps = new List<InstantiatedApps>();
            apps.Add(new InstantiatedApps(1, 100, "Test User", "Y", "Test Shop", "Appointment", 1000, 1200));

            var counts = apps.Count();

            Assert.True(counts == 1);
        }

        [Fact]
        public void CheckListAdditionMultipleItem()
        {
            // check multiple items are being added to the list with no external dependency 

            List<InstantiatedApps> apps = new List<InstantiatedApps>();
            apps.Add(new InstantiatedApps(1, 100, "Test User", "Y", "Test Shop", "Appointment", 1000, 1500));
            apps.Add(new InstantiatedApps(2, 100, "Test User", "Y", "Test Shop", "Appointment", 1200, 1100));
            apps.Add(new InstantiatedApps(3, 100, "Test User", "Y", "Test Shop", "Appointment", 1300, 1500));
            apps.Add(new InstantiatedApps(4, 100, "Test User", "Y", "Test Shop", "Appointment", 0900, 1300));

            var counts = apps.Count();

            Assert.True(counts == 4);
        }

        [Fact]
        public void InstantiateAppointments()
        {
            // manual check to ensure the appointment information provided and matches once added to the list

            var uninstantiatedId = 1;
            var uninstantiatedBarberId = 2;
            var uninstanatiedBarber = "Test Barber";
            var uninstantiatedBooked = "Y";
            var uninstantiatedShop = "Test Shop";
            var uninstantiatedName = "appointment";
            var uninstantiatedTime = 1000;
            var uninstantiatedPrice = 1200;

            InstantiatedApps i = new InstantiatedApps(uninstantiatedId, uninstantiatedBarberId, uninstanatiedBarber, uninstantiatedBooked, uninstantiatedShop, uninstantiatedName, uninstantiatedTime, uninstantiatedPrice);

           

            var instantiatedId = i.Id;
            var instantiatedBarberId = i.BarberID;
            var instantiatedBarber = i.Barber;
            var instantiatedBooked = i.Booked;
            var instantiatedShop = i.Shop;
            var instantiatedName = i.Name;
            var instantiatedTime = i.Time;
            var instantiatedPrice = i.Price;
                
           

            Assert.Equal(uninstantiatedId, instantiatedId);
            Assert.Equal(uninstantiatedBarberId, instantiatedBarberId);
            Assert.Equal(uninstanatiedBarber, instantiatedBarber);
            Assert.Equal(uninstantiatedBooked, instantiatedBooked);
            Assert.Equal(uninstantiatedShop, instantiatedShop);
            Assert.Equal(uninstantiatedName, instantiatedName);
            Assert.Equal(uninstantiatedTime, instantiatedTime);
            Assert.Equal(uninstantiatedPrice, instantiatedPrice);
        }

        [Fact]
        public void InstantiateProducts()
        {
            // manual check to ensure the product information provided and matches once added to the list

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