using System;

namespace ClassPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstClass = new Car();
            Console.WriteLine($"This {firstClass.Brand} is {firstClass.Color} and it cost {firstClass.Price}");
            var secondClass = new Car("Abuzabi");
            Console.WriteLine($"This {secondClass.Brand} is {secondClass.Color} and it cost {secondClass.Price}and petName is {secondClass.petName}");
         

            var thirdClass = new Driver("Anita", "Lewandowska", new DateTime(1993, 10, 11)); // jak dodwac daty - poprzez slowno new !
            Console.WriteLine($"This driver has license no: {thirdClass.DrivingNo} and his name is {thirdClass.name}");
         
            var forthClass = new CarBrand();
            Console.WriteLine($"This car comes form {forthClass.Manufacturer} and its date of release is {forthClass.DateOfRelese}");
            

            var fiveClass = new Driver("Łukasz","Dybała",new DateTime(1988,08,27), new Car());
            Console.WriteLine($"has date of birth{fiveClass.dateOfBirth} and his favorite brand of car is {fiveClass.CarList[0].Brand.brandName}"); // zamiast petli- wyswietlenie konkretnej pierwszej pozycji w liscie (indeksowanie)
            Console.WriteLine($"All his cars : ");

            for(int i = 0; i < fiveClass.CarList.Count; i++) 
            {
                Console.WriteLine(fiveClass.CarList[i].Color);
            
            }
            
            
            
            Console.ReadLine();
        }
      

    }
}
