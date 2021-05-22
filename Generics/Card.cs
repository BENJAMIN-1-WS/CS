using System;

using System.Text;

namespace Generic
{
    public class Card
    {
        private int shape;
        private int number;
        private string color;

        public Card(int number, int shape) 
        {
            this.shape = shape;
            this.number = number;
            this.color = number > 2 ? "Black" : "Red";
        }
        public Card(String color)
        {
            this.number = 15;
            this.shape = 5;
            this.color = color;
        }
        public bool isSame(Card other)
        {
            if (other.color == this.color && other.number==this.number)
            {
                return true;
            }
            return false;
        }
        public int Shape { get => shape; set => shape = value; }
        public int Number { get => number; set => number = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return this.number + " | " + this.shape + " | " + this.color;
        }
    }
}
