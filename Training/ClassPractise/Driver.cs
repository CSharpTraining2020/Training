using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractise
{
    public class Driver
    {
        /// pola

        public string name;
        public string surrname;
        public string drivingNo;
        public DateTime dateOfBirth;
        public string idNo;
        

        /// własciwosci 
        public string DrivingNo { get { return drivingNo; } set { drivingNo = value; } }
        public string IdNo { get { return idNo; } set { idNo = value; } }
        public List<Car>CarList { get; set; }// kierowca ma liczne samochody aby wypisac je anlezy utworzyc liste z istniejaca juz klasa Car

        /// Konstruktor
        public Driver() 
        {
           CarList = new List<Car>();// zainicjalizowanie putej listy aby nie wywoływało błedy w przypadku petli 
            this.DrivingNo = "56783/9273/9863";
            this.IdNo = "AUR87644";
        }

        public Driver(string name, string surrname, DateTime dateOfBirth) 
        {
            CarList = new List<Car>();
            this.name = name;
            this.surrname = surrname;
            this.dateOfBirth = dateOfBirth;
        }
        public Driver(string name, string surrname, DateTime dateOfBirth, Car parametrCar) 
        {
            this.name = name;
            this.surrname = surrname;
            this.dateOfBirth = dateOfBirth;
            this.CarList = new List<Car>();
            CarList.Add(parametrCar);

        }
        

    
    }
}
