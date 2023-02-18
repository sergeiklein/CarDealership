// See https://aka.ms/new-console-template for more information
using CarDealership;


Car mycar = new Car(12000, 2015, "Honda", "Oddysey", "Grey");//created several instances of class

Car car2 = new Car(22000, 2022, "Kia", "Soul", "Blue");

Car car3 = new Car(32000, 2023, "Tesla", "NewOne", "White");

Car car4 = new Car(45000, 2020, "Honda", "Pilot", "Black");

Car car5 = new Car(8000, 1995, "Lexus", "Something", "Gold");

Car car6 = new Car(17400, 2005, "Kia", "Sienna", "pink");

List<Car> carInventory= new List<Car>();// reating of list 
carInventory.Add(mycar);
carInventory.Add(car2);
carInventory.Add(car3);
carInventory.Add(car4);
carInventory.Add(car5);
carInventory.Add(car6);

Console.WriteLine(mycar.Price);

mycar.SetPrice(mycar.Price, "winter");
//foreach use with collections
foreach (Car car in carInventory)
    {
        Console.WriteLine(car.Color);
    }
Console.WriteLine(mycar.Price);

//// used if you know how many time you wnat to iterate
//for (int i = 0; i < carInventory.Count; i++)
//{
//    Console.WriteLine(carInventory[i].Make);
//}
////Lets review loops
//int num = 0;
//while (num < 6)//must be true to excecute at all
//{
//    Console.WriteLine(num);
//    num++;
//}
//int num2 = 0;
//do //will alwasy excecute at least once. becasue its checking condition after excecution
//{
//    Console.WriteLine(num2);
//    num2++;
//} while (num2 < 6);










//Car car2 = new Car(125000);

//Car car3 = new Car(-12000);
//Console.WriteLine(car3.Price);

//mycar.SetPrice(mycar.Price, "winter");
//Console.WriteLine(mycar.Price);
