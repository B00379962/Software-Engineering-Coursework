using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using DataAccessManager;

namespace APITests
{
    public class FileWriteTests
    {
        [Fact]
        public void CheckAppFileExport()
        {
            // check that appointment file has been written using last write time and system date time

            int appid = 99;
            string barbername = "Test";
            int barberids = 123;
            string shop = "Shop 1";

            AppointmentListFile slf = new AppointmentListFile();

            slf.AppClasses = new List<AppClass>()
            {

                new AppClass()
                {
                    Appointments = new List<Appointment>()
                    {
                        new Appointment()
                            {barber = barbername, BarberID = barberids, Id = appid, booked = "Y", shop = shop}
                    }
                }
            };

            XmlUtils.WriteXML(slf, AppDomain.CurrentDomain.BaseDirectory + @".\appointmentsbasket.xml");

            DateTime write = File.GetLastWriteTime(AppDomain.CurrentDomain.BaseDirectory + @".\appointmentsbasket.xml");
            var writeHour = write.Hour;
            var writeMinute = write.Minute;
            var writeMinuteHour = writeHour + ":" + writeMinute;

            var currentTime = DateTime.Now;

            var currentHour = currentTime.Hour;
            var currentMinute = currentTime.Minute;

            var hourMinute = currentHour + ":" + currentMinute;
           
            Assert.Equal(hourMinute, writeMinuteHour);
        }

        [Fact]
        public void CheckProdFileExport()
        {
            // check that product file has been written using last write time and system date time

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


            XmlUtils.WriteXML(slf, AppDomain.CurrentDomain.BaseDirectory + @".\productsbasket.xml");

            DateTime write = File.GetLastWriteTime(AppDomain.CurrentDomain.BaseDirectory + @".\productsbasket.xml");
            var writeHour = write.Hour;
            var writeMinute = write.Minute;
            var writeMinuteHour = writeHour + ":" + writeMinute;

            var currentTime = DateTime.Now;
            var Current = DateTime.Now;
            var currentHour = currentTime.Hour;
            var currentMinute = currentTime.Minute;

            var hourMinute = currentHour + ":" + currentMinute;
            
            Assert.Equal(hourMinute, writeMinuteHour);
        }


    }
}
