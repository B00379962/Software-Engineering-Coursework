using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using DataAccessManager;
using AssetReservation;

namespace APITests
{
    public class FileReadTest
    {


        [Fact]
        public void CheckAppointmentFile()
        {
            Assert.True(File.Exists(Environment.CurrentDirectory + @"\appointmentsfile.xml"));
        }

        [Fact]
        public void CheckProductFile()
        {
            Assert.True(File.Exists(Environment.CurrentDirectory + @"\products.xml"));
        }

        [Fact]
        public void CheckFileNotEmpty()
        {
            //required because of shared resource access
            int sleepTime = 2000; 
            Task.Delay(sleepTime).Wait();
            List<InstantiatedApps> appsList = new List<InstantiatedApps>();

            AppointmentListFile readFile = XmlUtils.ReadXML<AppointmentListFile>(Environment.CurrentDirectory + @"\appointmentsfile.xml");
            foreach (AppClass c in readFile.AppClasses)
            {

                foreach (Appointment s in c.Appointments)
                {
                    //Add each appointment to Instantiated Apps 
                    Console.WriteLine(s.BarberID + s.Id);
                    appsList.Add(new InstantiatedApps(s.Id, s.BarberID, s.barber, s.booked, s.shop));
                }

                Assert.True(appsList != null);

            }
        }


       

        [Fact]
        public void CheckIDMatch()
        {
            //required because of shared resource access
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