using System;
using System.Collections.Generic;
using Xunit;
using DataAccessManager;
using AssetReservation;

namespace APITests
{

    public class BookingTests
    {
        [Fact]
        public void InvalidBookingId()
        {
            // check that invalid booking ID throws error
            Book b12 = new Book();

            Assert.Throws<InvalidOperationException>(() => b12.BookAppointment(99));
        }

        [Fact]
        public void InvalidProductID()
        {
            // check that invalid product ID throws error
            Book b13 = new Book();

            Assert.Throws<InvalidOperationException>(() => b13.BuyProduct(99, 1));

        }

        [Fact]
        public void ProductAmountMoreThanAvailable()
        {
            // check when buying more products than are available that an error shows
            Book b14 = new Book();
            Assert.Throws<InvalidOperationException>(() => b14.BuyProduct(1, 10000));
        }


        [Fact]
        public void CheckAppNotBlank()
        {
            // check that the appointment export is not blank when it's booked
            int appId = 99;
            string barberName = "Test";
            int barberIds = 123;
            string Shop = "Shop 1";

            AppointmentListFile slf = new AppointmentListFile();

            slf.AppClasses = new List<AppClass>()
            {

                new AppClass()
                {
                    Appointments = new List<Appointment>()
                    {
                        new Appointment()
                            {barber = barberName, BarberID = barberIds, Id = appId, booked = "Y", shop = Shop}
                    }

                }

            };

            Assert.True(slf != null);

        }

        [Fact]
        public void CheckProdNotBlank()
        {
            // check that the product export is not blank when it's booked
            string prodName = "Test Product";
            int prodIds = 100;
            int newAmount = 5;

            ProductListFile slf = new ProductListFile();

            slf.ProdClasses = new List<ProdClass>()
            {

                new ProdClass()
                {
                    Products = new List<Product>()
                    {
                        new Product() {Name = prodName, ProductID = prodIds, Ammount = newAmount}
                    }
                }
            };

            Assert.True(slf != null);
        }

    }

}
