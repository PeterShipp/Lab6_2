using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_3_OOP
{
    class CoffeeMug
    {
        private string color { get; set; }
        private string textColor { get; set; }
        private string phrase { get; set; }
        private int size { get; set; }
        private bool isFull { get; set; }

    

        public CoffeeMug(string whatColor, string whatTextColor, string whatPhrase, int whatSize)
        {
            this.color = whatColor;
            this.textColor = whatTextColor;
            this.phrase = whatPhrase;
            this.size = whatSize;
            this.isFull = false;

        }

        public void Fill()
        {
            if (isFull == false)
            {
                isFull = true;
                Console.WriteLine("You poured coffee into " + phrase);
            }

            else
            {
                Console.WriteLine("Coffee spills ALL OVER THE PLACE! It was already full, What were you thinking?!");
            }
        }

        public void Drink()
        {
            if (isFull == true)
            {
                isFull = false;
                Console.WriteLine("You poured coffee into " + phrase);
            }

            else
            {
                Console.WriteLine("Coffee spills ALL OVER THE PLACE! It was already full, What were you thinking?!");
            }
        }
    }
}



