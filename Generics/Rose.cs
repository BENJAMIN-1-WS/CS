using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Rose : Flower
    {
        private string color;
        public Rose(int val, string color) : base(val) {this.color = color;}
        public bool validHigth() { return higth > 10 && higth < 20; }
                                                                                                                                                         
    }
}
