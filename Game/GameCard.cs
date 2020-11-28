using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Card_Game
{
    class Test
    {
        public class Card
        {
            private int value;
            private int shap;
            public Card(int value, int shap)
            {
                this.value = value;
                this.shap = shap;
            }
            public int GetValue() { return this.value; }
            public int GetShap() { return this.shap; }
            public void SetShap(int s) { this.shap = s; }
            public void SetValue(int v) { this.value = v; }

        }
        public class Deek
        {
            private Card[] Cards;
            private int pos = 0;

            public Deek()
            {
                this.Cards = new Card[49];
            }

            public void insert(Card ca)
            {
                if (ca.GetShap() == 1)
                {
                    ca = Cards1[pos1];
                    pos1++;
                }
                else if (ca.GetShap() == 2)
                {
                    ca = Cards2[pos2];
                    pos2++;
                }
                else if (ca.GetShap() == 3)
                {
                    ca = Cards3[pos3];
                    pos3++;
                }
                else if (ca.GetShap() == 4)
                {
                    ca = Cards4[pos4];
                    pos4++;
                }
            }


            public bool Move()
            {
                Random r = new Random();
                int RandomNumber = r.Next(1, 5);


                if (RandomNumber == 1)
                {
                    if (pos1 == 0)
                        return false;

                    this.Cards5[pos5] = this.Cards1[pos1 - 1];
                    pos5++;
                    pos1--;
                }
                if (RandomNumber == 2)
                {
                    if (pos2 == 0)
                        return false;

                    this.Cards5[pos5] = this.Cards2[pos2 - 1];
                    pos5++;
                    pos2--;

                }
                if (RandomNumber == 3)
                {
                    if (pos3 == 0)
                        return false;

                    this.Cards5[pos5] = this.Cards3[pos3 - 1];
                    pos5++;
                    pos3--;

                }
                if (RandomNumber == 4)
                {
                    if (pos4 == 0)
                        return false;

                    this.Cards5[pos5] = this.Cards4[pos4 - 1];
                    pos5++;
                    pos4--;
                }
                return true;
            }
            public int sum()
            {
                int sum = 0;
                for (int i = 0; i <= pos5; i++)
                {
                    sum += this.Cards5[i].GetValue();
                }
                return sum;
            }

        }

        public static Card[] BildingCards()
        {

            Card[] a = new Card[52];
            Random rr = new Random();
            int i = 0;

            while (i < a.Length)
            {
                int rndV = rr.Next(1, 14);
                int rndS = rr.Next(1, 5);

                for (int j = 0; j < a.Length; j++)
                {
                    if (rndV == a[j].GetValue() || rndS == a[j].GetShap())
                    {
                        rndS = rr.Next(1, 5);
                        rndV = rr.Next(1, 14);
                        j = 0;
                    }
                }
                a[i] = new Card(rndV, rndS);
                i++;
            }
            return a;
        }
        public static bool Game(Card[] cards)
        {
            Deek d1 = new Deek();
            for (int i = 0; i <= 49; i++)
                d1.insert(cards[i]);

            while (d1.Move()) ;

            int sum = d1.sum();

            if (sum % 100 == 0)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            Card[] r = BildingCards();

            Console.WriteLine(Game(r));
        }
    }
}


namespace TIME_PRO
{
    class Time
    {
        private int hour;
        private int min;
        private Time time;

        public Time(int h, int m)
        {
            this.min = m;
            this.hour = h;
        }
        public Time()
        {
            this.min = 00;
            this.hour = 8;
        }
        public override string ToString()
        {
            if (this.min < 10)
            {
                return this.hour + ":0" + this.min;
            }
            return this.hour + ":" + this.min;
        }
        public int GetH()
        {
            return this.hour;
        }
        public int GetM()
        {
            return this.min;
        }
        public Time(Time t)
        {
            this.hour = t.GetH();
            this.min = t.GetM();
        }


        public int dis(Time time)
        {
            return Math.Abs((this.hour * 60 + this.min) - (time.GetH() * 60 + time.GetM()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(9, 3);
            Console.WriteLine(t);
        }
    }
}
