using System;
namespace Taxi
{
    class Program
    {
        public class Taxi
        {
            private string id;
            private string name;
            private int numPass;
            private bool avible;

            public Taxi(string id, string name)
            {
                this.id = id;
                this.name = name;
                this.numPass = 4;
                this.avible = true;
            }
            public Taxi(string id, string name, int numPass)
            {

                this.id = id;
                this.name = name;
                this.numPass = numPass;
                this.avible = true;
            }
            public Taxi(Taxi taxi)
            {

                this.id = taxi.id;
                this.name = taxi.name;
                this.numPass = taxi.numPass;
                this.avible = taxi.avible;
            }
            public int getNumPass()
            {
                return this.numPass;
            }
            public string getName()
            {
                return this.name;
            }
            public override string ToString()
            {
                return 
                    "\n\t_______Taxi________\n" +
                    "\tid: " + this.id + "\n" +
                    "\tname: " + this.name + "\n"+
                    "\tnumPass: " + this.numPass + "\n" +
                    "\tavible => " + this.avible + "\n"+
                    "\t___________________\n" ;
            }
        }
            public static int taxiBusy2(Taxi [] taxis, int Pass)
            {
                int total = 0;
                for (int i = 0;taxis[i]!=null; i++)
                {
                    total+= taxis[i].getNumPass();
                }
                //total=0 pass=4

                for (int i = 0;taxis[i] != null; i++) 
                {
                    if (Pass <= 5)
                    {

                        if ((total - Pass) == 0)
                        {
                            Console.WriteLine("Excellent! Full match ");
                            return total - Pass;
                        }
                        else
                        {
                            Console.WriteLine("Needs improvement");
                            Console.WriteLine("the Taxi of " + taxis[i].getName() + "  getOut with " + (total - Pass) + " available spaces");
                            return total - Pass;
                        }
                        
                    }
                    else
                    {
                        Pass -= taxis[i].getNumPass();
                        total -= taxis[i].getNumPass();
                    }
                }
                Console.WriteLine("Not ok\ntotal={0}<{1}=Pass",total, Pass);
                Console.WriteLine("You have " + Math.Abs(total - Pass) + " People without a taxi");
                return total - Pass;
            }
        static void Main(string[] args)
        {
            Taxi david = new Taxi("41-954-45", "david");
            Taxi shimi = new Taxi("41-954-45", "shimi",5);
            Taxi arik = new Taxi("41-954-45", "arik",5);
            Taxi [] taxis = new Taxi[20];
            taxis[0] = david;//=4
            taxis[1] = arik;//=5
            taxis[2] = shimi;//=5
            taxiBusy2(taxis, 20); 

        }
    }
}
