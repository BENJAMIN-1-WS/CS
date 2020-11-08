using System;
using System.Xml.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using System.Dynamic;

namespace DICE
{
    class Program
    {
        public class ArrDie
        {
            private Die[] die1;
            public ArrDie(int NewNum)
            {
                this.die1 = new Die[NewNum];
                for (int i = 0; i < NewNum; i++)
                {
                    Console.WriteLine("input mimad: ");
                    int mimad = int.Parse(Console.ReadLine());
                        Die d= new Die(mimad);
                    this.die1[i] = d;
                }

            }

            public int Gettotal()
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 101);
                Console.WriteLine("Random % => {0}", x);
                int t = 0;
                for (int i = 0; i < this.die1.Length; i++)
                {
                    t += die1[i].GetVal();
                }
                return (t%x);
            }
        }

        public class Die
        {
            private int mimad;
            private int val;
            public Die(int mimad)
            {
                this.mimad = mimad;
                Random rnd = new Random();
                this.val = rnd.Next(1, this.mimad + 1);
                Console.WriteLine("Dice=> {0}", this.val);
            }
           
            public int GetVal()
            {
                return this.val;
            }

        }
        public class Game
        {
            private int pnum;
            private int[] arrPoints;
            private string[] ArrName;
            public Game()
            {
                Console.WriteLine("how much plyers?");
                int NewPnum = int.Parse(Console.ReadLine());

                this.pnum = NewPnum;
                this.ArrName = new string[this.pnum];
                this.arrPoints = new int[this.pnum];
                for (int i = 0; i < this.ArrName.Length; i++)
                {
                    Console.WriteLine("player {0} input your name: ", i + 1);
                    this.ArrName[i] = Console.ReadLine();
                }
                for (int i = 0; i < this.ArrName.Length; i++)
                {
                    Console.WriteLine("Player {0}: {1}", i + 1, this.ArrName[i]);
                }

                Console.WriteLine("\n_____");
                Play();
            }


            public void Play()
            {
                for (int i = 0; i < this.pnum; i++)
                {
                How_Much_Cube:
                    Console.WriteLine("{0} How Much Cube You Whant: ", this.ArrName[i]);
                    int numofdices = int.Parse(Console.ReadLine());
                    try
                    {
                        if (numofdices <= 0)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Number Must Be > 0");
                        goto How_Much_Cube;
                    }

                    ArrDie d1 = new ArrDie(numofdices);
                    this.arrPoints[i] = d1.Gettotal();
                    Win();
                }

            }
            public string Winner()
            {
                Console.WriteLine("\t_____________Scoreboard______________");
                for (int i = 0; i < this.ArrName.Length; i++)
                {
                    Console.WriteLine("\tplayer: {0} | you have: {1} points.", this.ArrName[i], this.arrPoints[i]);

                }
                string winner = "";
                for (int i = 0; i < this.arrPoints.Length - 1; i++)
                {
                    if (this.arrPoints[i] > this.arrPoints[i + 1])
                    {
                        winner = this.ArrName[i];
                    }
                    else
                    {
                        winner = this.ArrName[i + 1];
                    }
                }
                return "\tMazel Tov !!winner : " + winner + " !!!" + "\n\t_______________________________________";
            }
          

            public bool Win()
            {
                for (int i = 0; i < this.arrPoints.Length; i++)
                {
                    if (this.arrPoints[i] > 1000)
                    {
                        Console.WriteLine("BATAHLES NIGMAR AVAL SAHEK!");
                        return true;
                    }
                }
                Console.WriteLine("ALLA! LO NIGMAR!");
                return false;
            }



        }

        public static void THE_KING_HAYU()
        {
            Game g1 = new Game();
            Console.WriteLine(g1.Winner());
        }
        static void Main(string[] args)
        {
            THE_KING_HAYU();
        }
    }


}