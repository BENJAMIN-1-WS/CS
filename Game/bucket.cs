  class Program
    {
        public class CapacityException : Exception { }
        public class Bucket
        {
            private int capacity;
            private double currentAmount;
            private string color;
            public Bucket(double currentAmount, string color)
            {
            start:
                this.capacity = 10;
                this.currentAmount = currentAmount;
                try
                {
                    if (color == "red" || color == "green" || color == " blue" || color == "white")
                    {
                        this.color = color;
                    }
                    else { 
                        throw new CapacityException();

                    }
                }
                catch (CapacityException)
                {
                    Console.WriteLine("your color is : " + color);
                    Console.WriteLine("worng! select one option: red , green , blue , white .");
                    Console.WriteLine("select color:\n");
                    this.color = Console.ReadLine();
                    if (this.color == "red" || this.color == "green" || this.color == " blue" || this.color == "white")
                    {
                        this.color = this.color;
                    }
                    else goto start;
                }
            }
            public Bucket(Bucket CopyBucket)
            {
                this.currentAmount = CopyBucket.currentAmount;
                this.color = CopyBucket.color;
                this.capacity = 10;
            }
            public void Empty()
            {
                this.currentAmount = 0;
            }
            public bool IsEmpty()
            {
                if (this.currentAmount == 0)
                {
                    return true;
                }
                return false;
            }
            public void Fill(double fill)
            {
                if (this.capacity < this.currentAmount + fill)
                    this.currentAmount = this.capacity;
                else
                    this.currentAmount += fill;
            }
            public int Getcapacity()
            {
                return this.capacity;
            }
            public double GetcurrentAmount()
            {
                return this.currentAmount;
            }
            public void PourInto(Bucket b1)
            {
                double distance = b1.Getcapacity() - b1.GetcurrentAmount();

                if (this.currentAmount < distance)
                {
                    b1.Fill(this.currentAmount);
                    this.currentAmount = 0;
                }
                else
                {
                    b1.Fill(distance);
                    this.currentAmount -= distance;
                }
            }
            public override string ToString()
            {
                return "capacity: " + this.capacity + " currentAmount: " + this.currentAmount + " color: " + this.color;
            }
        }

        static void Main(string[] args)
        {
        main:
            try
            {
                Console.WriteLine("select currentAmount: ");
                double currentAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("select color: ");
                string color = Console.ReadLine();
                Bucket b1 = new Bucket(currentAmount, color);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong !! try agein: ");
                goto main;
            }
        }
    }
