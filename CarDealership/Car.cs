using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Car//--------------------------------------------------------------------------created a class----------------------------------------
    {
        //fields are private class members
        //THink of fields as local variables that 
        //exist throughout your class
        //These fields will have access to the methods 
        //and constructors in your class
        //fields is where actaul data being stored

        private double price;//------------------------------------------------------------------created fields---------------------------------------
        private int year;
        private string model;
        private string make;
        private string color;
        private double discount;
        //declare fields as private
        //provide public properties with get set methods to
        //access and update that private field
        //Think of a property as a combination of variable and a method that has Get and Set Methods
        //THe get method returns the value of the variable
        // Set method assigns the value
        public double Price//---------------------------------------------------------------------creating properties---------------------------------
        {
            get
            {
                return price;   
            }
            set
            {
                if(value > 0) //General Variable built info VS
                {
                    price = value;
                }
            }
        }
        
        public int Year { get; set; }   
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public double Discount { get; set; }
       
        // Create Constructor 
        //should be same name as the class
        public Car(double price, int year, string model, string make, string color)//---------------creating a constructor---------------------------
        {
            Price = price; 
            Year= year;
            Model = model;
            Make = make;
            Color = color;

        }

        public Car(double price)//-----------------------------------------------------------------creating another constructor----------------------
        {
            Price = price;
        }

        //Discount 30 percent of in the winter, 20 in the fall, 10 in the summer, 5 in the spring

        public void SetPrice(double price, string season)// ---------------------------------------creating a method for season----------------------
        {
            switch(season)
            {
                case "fall":
                    discount = .20;
                    break;
                case "winter":
                    discount = .30;
                    break;
                case "summer":
                    discount = .10;
                    break;
                case "spring":
                    discount = .05;
                    break;

                default:
                    Console.WriteLine("Enter a Valid season");
                    break;
            }
            Price = price - (price * discount);
        }
     





    }
}
