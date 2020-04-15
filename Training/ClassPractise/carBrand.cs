using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractise
{
    public class CarBrand
    {
        public string brandName;
        public string manufacturer;
        public DateTime dateOfRelese;



        public string BrandName { get { return brandName; } set { brandName = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public DateTime DateOfRelese { get { return dateOfRelese; } set { dateOfRelese = value; } }

        public CarBrand() 
        {
            this.BrandName = "Mercedes";
            this.Manufacturer = "Mercedes Company SP.z.o.o";
            this.DateOfRelese = new DateTime(1999, 01, 01);
        
        }
        public CarBrand(string brandName) 
        {
            this.BrandName = brandName;
        }
    }

    
}
