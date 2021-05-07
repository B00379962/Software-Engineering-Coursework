using System;
using System.Collections.Generic;
using DataAccessManager;


namespace AssetReservation
{
    public class Book
    {

        public void BookAppointment(int appId)
        {
            GetAppointment(appId);
        }

        public void BuyProduct(int prodId, int amount)
        {
            GetProduct(prodId, amount);
        }

        private void GetAppointment(int appid)
        {
            // read in appointments

            Rappointments r1 = new Rappointments();
            r1.Create();

            // get appointment with ID specified
            InstantiatedApps a = r1.GetById(appid);

            // check appointment is not null
            if (a != null)
            {


                int appointmentId = a.Id;
                string barberName = a.Barber;
                int barberIds = a.BarberID;
                string Shop = a.Shop;
               

                //write file method 
                AppFileWrite(appointmentId, barberName, barberIds, Shop);
            }
            else
            {
                // if ID given does not exist show error
                throw new InvalidOperationException("That is not a valid appointment ID");
            }
        }

        private void AppFileWrite(int Id, string barberName, int barberIds, string Shop)
        {
            AppointmentListFile appList = new AppointmentListFile();

            //construct XML appointment for export
            appList.AppClasses = new List<AppClass>()
            {

                new AppClass()
                {
                    Appointments = new List<Appointment>()
                    {
                        new Appointment()
                            
                            {barber = barberName, BarberID = barberIds, Id = Id, booked = "Y", shop = Shop}
                    }
                }
            };

            //check that structure is not blank
            if (appList.AppClasses != null)
            {
                //write file
                XmlUtils.WriteXML(appList, Environment.CurrentDirectory + @"\appointmentsbasket.xml");
            }
            else
            {
                throw new InvalidOperationException("That is not a valid appointment ID");
            }
        }

        private void GetProduct(int prodId, int amount)
        {

            // read in products
            Rproducts p1 = new Rproducts();
            p1.Create();

            // get product with ID specified 
            InstantiatedProducts p = p1.GetById(prodId);

            // check ID exists
            if (p != null)
            {
                // check the number of items requested is in stock
                if (p.amount >= amount)
                {

                    string prodName = p.Name;
                    int prodIds = p.Prodid;
                    int Amount = p.amount;
                    int newAmount = Amount - amount;

                    // write file method
                    ProdFileWrite(prodName, prodIds, newAmount);
                }
                else
                {
                    throw new InvalidOperationException("There is not enough of the product requested remaining");
                }
            }
            else
            {
                throw new InvalidOperationException("That is not a valid product ID");
            }
        }

        private void ProdFileWrite(string prodName, int prodIds, int newAmount)
        {

            
            ProductListFile prodList = new ProductListFile();

            // construct XML for product
            prodList.ProdClasses = new List<ProdClass>()
            {

                new ProdClass()
                {
                    Products = new List<Product>()
            {
                new Product(){Name=prodName, ProductID=prodIds, Ammount=newAmount}
                    }
                }
            };

            // export product to file
            XmlUtils.WriteXML(prodList, Environment.CurrentDirectory + @"\productsbasket.xml");


        }
    }
}
