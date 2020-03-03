using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_3_OOP
{
    class Program
    {
        static void Main(String[] arg)
        {
            CoffeeMug mug1 = new CoffeeMug("white", "black", "World's Best Daddy", 16);
            CoffeeMug mug2 = new CoffeeMug("black", "gold", "Rise & Shine", 12);

            Console.WriteLine(mug1);
            Console.WriteLine(mug2);

            mug1.Fill();
            mug1.Drink();
            mug1.Drink();
            mug1.Fill();

            Animal animal1 = new Animal(4, 0, "Cat", "Snowball", true);
            Animal animal2 = new Animal(8, 0, "Spider", "Friendly the Spider", false);
            Animal animal3 = new Animal(2, 2, "Monkey", "Bobo", false);

            animal1.ShowDetails();
            animal2.ShowDetails();
            animal3.ShowDetails();
        }
    }
   
    
}
