using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractise
{
    public class Car
    {
        private CarBrand brand;
        internal double price;
        public string petName;

        public string Engine { get; set; } // wlasciwosc 
        public double Price { get { return price; } set { price =value; } } // wielkosc znakow ma znaczenie = nazwa wlasciowsci z duzej, pola z małej
        public string Color { get; set; }
        public CarBrand Brand { get { return brand; } set { brand = value; } }

        public Car()  // konstruktor towrze poprzez uzycie nazwy klasy 
        {
            this.Price = 1000;
            this.Color = "black";
            this.Brand = new CarBrand("Mercedes ( its time to grow up");
        }
        public  Car(string petName) 
        {
            this.petName = petName;
            this.Color = "red";
            this.Price = 2500;
            this.Brand = new CarBrand("volvo");
        }
        
    }
}
