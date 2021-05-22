using System;
using System.Collections;
using System.Text;

namespace Generic
{
    class Pack
    {
        ArrayList cards = new ArrayList();
        public Pack(){
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(1, i));
                cards.Add(new Card(2, i));
                cards.Add(new Card(3, i));
                cards.Add(new Card(4, i));
            }
            cards.Add(new Card("Red"));
            cards.Add(new Card("Black"));
        }


        public void printPack() {
            for (int i = 0; i < this.cards.Count; i++)
            {
                Console.WriteLine(this.cards[i].ToString());
            }
        }
    }
}
