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

            Jolle.Make = "OceanMaster";
            Jolle.Model = "WaveDrifter3000";
            Jolle .Move();
            g6.Make = "G6";
            g6.Model = "Norweigian AirLines";
            g6.Move();


            List<Vechiles > list = new List<Vechiles> ();
            list.Add(Volvo740);
            list.Add(Jolle);
            list.Add(g6);





            



        }
    }
}