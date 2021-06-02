using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Square : Rectangle
    {
        private readonly string name;
        private double length;

        
        public Square(double length) 
        {
            this.length = length;
        }
    }
}
