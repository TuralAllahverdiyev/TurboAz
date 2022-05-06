using System;
using System.Collections.Generic;
using TurboAz.Classes;

namespace TurboAz
{
    class Program
    {
        static void Main(string[] args)
        {

            Announcement announcement = new Announcement();
            Marka marka = new Marka();
            Model<string> model = new Model<string>();
            Admin admin = new Admin();
            User user = new User();

             announcement=


            

            Console.WriteLine(announcement.Marka.Year = 2008);
            Console.WriteLine(announcement.Marka.Price = 20000);
            Console.WriteLine(announcement.Marka.City = "Baku");
            Console.WriteLine(announcement.Model.ModelName = "E-class");
            Console.WriteLine(announcement.Model.KM = 125.500);
            Console.WriteLine(announcement.Model.BanType = Ban.sedan);
            Console.WriteLine(announcement.Model.FuelType = Fuel.gasoline);
            Console.WriteLine(announcement.Model.GearType = Gearbox.automatic);
            Console.WriteLine(announcement.Model.Color = Colors.black);
            Console.WriteLine(announcement.Date = DateTime.Today);



            //try
            //{
            //    DateTime date1 = announcement.Date;
            //    Console.WriteLine("Elanin yerleshdirildiyi tarixi" + " " + date1);
            //    DateTime date2 = date1.AddDays(30);
            //    Console.WriteLine("Elanin bitme tarixi" + " " + date2);
            //    if (DateTime.Now > date2)
            //    {
            //        throw new ErrorException("error", Reason.ElaninMuddeti);
            //    }


            //}
            //catch (ErrorException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.sebeb);
            //}

            //catch (Exception e)
            //{

            //    Console.Write(e.StackTrace);
            //    Console.Write(e.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Elan");
            //}







        }
    }
}