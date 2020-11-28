using System;
using System.Xml.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace DICE
{
    class Program
    {
        public class ArrDie
        {
            private int num;
            private Die[] die1;
            public ArrDie(int NewNum)
            {
                this.die1 = new Die[NewNum];
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < NewNum; i++)
                {
                    this.die1[i] = new Die(size);
                }
            }
            public void AddDie(Die die,int pos)
            {
                for (int i = 0; i < die1.Length; i++)
                {
                    this.die1[pos] = die;
                }
                pos++;
            }
            public override string ToString()
             {
                 string str = "";
                 for (int i = 0; i < die1.Length; i++)
                 {
                     str += this.die1[i];
                 }
                return str;
             }
        }
        
        public class Die
        {
            private int n = 6;
            private int x;
            private string str;
            public Die()
            {
                this.n = 6;
            }
                public Die(int x)
            {
                this.x = x;
                if (x == 1)
                {
                    this.str = "\n|__*__|";
                }
                if (x == 2)
                {
                    this.str = "|__*__|\n|__*__|";
                }
                if (x == 3)
                {
                    this.str = "\n|__*__|\n|__*__|\n|__*__|";
                }
                if (x == 4)
                {
                    this.str = "\n|_*_*_|\n|_*_*_|";
                }
                if (x == 5)
                {
                    this.str = "\n|_*_*_|\n|__*__|\n|_*_*_|";
                }
                if (x == 6)
                {
                    this.str = "\n|_*_*_|\n|_*_*_|\n|_*_*_|";
                }
            }
            public void SetX(int x,int n)
            {
                this.x = x;
            }
            public int GetN()
            {
                return this.n;
            }
            public int GetX()
            {
                return this.x;
            }
            public string GetStr()
            {
                return this.str;
            }

            public void Roll()
            {
            start:
                Console.WriteLine("Put Your name: ");
                string name = Console.ReadLine();
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("{0} Rolling Dice..",name);
                System.Threading.Thread.Sleep(2000);
                Random rnd = new Random();
                int r = rnd.Next(1, 7);
                Die di1 = new Die(r);
                Console.WriteLine(di1);
                Console.WriteLine("\njust a sec >>\n");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Computer Rolling Dice..");
                System.Threading.Thread.Sleep(2000);
                Random rnd2 = new Random();
                int r2 = rnd.Next(1, 7);
                Die di2 = new Die(r2);
                Console.WriteLine(di2);

                if(di1.GetX()>di1.GetX())
                    Console.WriteLine("Die 1 Win!");
                else Console.WriteLine("Die 2 Win!");

                Console.WriteLine("Play Agine? y/n");
                char a =char.Parse( Console.ReadLine());
                if (a == 'y')
                    goto start;
                if (a == 'n')
                    goto finish;
                finish: Console.WriteLine("GOODBAY!");
            }
            public override string ToString()
            {
                return this.str+"\n";
            }
        }

        static void Main(string[] args)
        {
            Die d = new Die();
            d.Roll();
        }
    }
}

