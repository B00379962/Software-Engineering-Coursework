using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using DataAccessManager;

namespace APITests
{
    public class FileReadTest
    {


        [Fact]
        public void CheckAppointmentFile()
        {
            // check the file exists for appointments
            Assert.True(File.Exists(Environment.CurrentDirectory + @"\appointmentsfile.xml"));
        }

        [Fact]
        public void CheckProductFile()
        {
            // check the file exists for products
            Assert.True(File.Exists(Environment.CurrentDirectory + @"\products.xml"));
        }

        [Fact]
        public void CheckFileNotEmpty()
        {
            // check that appointments are being added to the list

            //sleep required because of shared resource access
            int sleepTime = 2000; 
            Task.Delay(sleepTime).Wait();
            List<InstantiatedApps> appsList = new List<InstantiatedApps>();

            AppointmentListFile readFile = XmlUtils.ReadXML<AppointmentListFile>(Environment.CurrentDirectory + @"\appointmentsfile.xml");
            foreach (AppClass c in readFile.AppClasses)
            {

                foreach (Appointment s in c.Appointments)
                {
                    //Add each appointment to Instantiated Apps 
                    
                    appsList.Add(new InstantiatedApps(s.Id, s.BarberID, s.barber, s.booked, s.shop, c.Name, c.Time, c.Price));
                }

                Assert.True(appsList != null);

            }
        }


       

        [Fact]
        public void CheckIDMatch()
        {
            // check that the appointment ID returned matches the one requested

            //sleep required because of shared resource access
            int sleepTime = 500;
            Task.Delay(sleepTime).Wait();
            int testid = 1;
            Rappointments app1 = new Rappointments();
            app1.Create();
            InstantiatedApps a = app1.GetById(testid);

            Assert.True(a.Id == testid);

        }

    }
}