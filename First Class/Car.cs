using System;
using System.Text;

namespace First_Class
{
    public class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public int FuelFor1km;
        public int CurrentFuel;

        public Car(string brand, string model, int fuelCapacity, int fuelFor1km, int year) : base(year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1km = fuelFor1km;
        }
        public int Drive(int driveroad, out int LastFuel)
        {
            int CanDrive = driveroad * FuelFor1km;
            if (CanDrive < FuelCapacity)
            {
                LastFuel = FuelCapacity - CanDrive;
            }
            else
            {
                LastFuel = 0;
                Console.WriteLine("Yanacaq bitib");
            }

            return LastFuel;
        }
        public void ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Model: {this.Model},Brand: {this.Brand},Fuel capacity: {this.FuelCapacity},Fuel for 1 km: {this.FuelFor1km},Current fuel: {this.CurrentFuel}");


            Console.WriteLine(sb.ToString());

        }






    }


}




