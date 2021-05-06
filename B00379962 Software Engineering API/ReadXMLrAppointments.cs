using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManager
{
    public class Rappointments : ReadFile
    {
        private List<InstantiatedApps> _appsList = new List<InstantiatedApps>();

        public override object Read()
        {
            //This method reads in the appointments and adds them to Instantiated Apps
                AppointmentListFile readFile = XmlUtils.ReadXML<AppointmentListFile>(Environment.CurrentDirectory + @"\appointmentsfile.xml");
                foreach (AppClass c in readFile.AppClasses)
                {
                    foreach (Appointment s in c.Appointments)
                    {
                        //Add each appointment to Instantiated Apps 
                        _appsList.Add(new InstantiatedApps(s.Id, s.BarberID, s.barber, s.booked, s.shop, c.Name, c.Time, c.Price));
                    }
                }
                // return the instantiated apps
                return _appsList;
        }

        public InstantiatedApps GetById(int id)
        {
            // used to return only 1 appointment from instantiated apps using the barber ID
            return this._appsList.FirstOrDefault(z => z.Id == id);
        }
    }
}
