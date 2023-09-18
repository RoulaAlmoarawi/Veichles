namespace arv
{
    internal class Program
    {
                
        static void Main(string[] args)
        {
         
            Bicycly bicycly1  = new Bicycly();
            Bus bus1=   new Bus();
            Car car1 =new Car();
            Airplane airplane1= new Airplane();
            MiniVan miniVan1 = new MiniVan();
            Scooter scooter1 = new Scooter();
            Rollerskates rollerskates1 = new Rollerskates();
            Hot_Air_ballon hotAirBallon1  = new Hot_Air_ballon();
            Boat boat1 = new Boat();
            Jet_Ski jetski1 = new Jet_Ski();
            Helicopter helicopter1 = new Helicopter(); 
            Segway segway1 = new Segway();
            Fire_Truck fireTruck1 = new Fire_Truck();
            Motorcycle motorcycle1 = new Motorcycle();
            Golf_cart golf_Cart1 = new Golf_cart();
            Sailboat sailboat1= new Sailboat();
            Submarine submarine1 = new Submarine();
            Truck truck1 = new Truck();
            Yacht yacht1 = new Yacht();
            Moped moped1 = new Moped();

            car Volvo740 = new car();
            Boat Jolle = new Boat();
            Airplane g6 = new Airplane();
           
            Volvo740.Make = "Volvo";
            Volvo740.Model = "740";
            Volvo740.Move();
            Volvo740.Year = 1999;
            Volvo740.Weight = 2500;
            Volvo740.speed = 220;
            Volvo740.Color = "Red";


            Jolle.Make = "OceanMaster";
            Jolle.Model = "WaveDrifter3000";
            Jolle .Move();
            Jolle.Year = 2021;
            Jolle.Weight = 1500;
            Jolle.speed = 10;
            Jolle.Color = "Gray";

            g6.Make = "G6";
            g6.Model = "Norweigian AirLines";
            g6.speed = 1000;
            g6.Weight = 1000;
            g6.Color = "Blue";
            g6.Year = 2022;

            g6.Move();


            List<Vechiles > list = new List<Vechiles> ();
            list.Add(Volvo740);
            list.Add(Jolle);
            list.Add(g6);





            



        }
    }
}