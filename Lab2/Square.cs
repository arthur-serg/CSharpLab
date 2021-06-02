using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Square : Rectangle
    {
        string Name { get; set; } = "Square";
        private double length;
        
        public Square(double length) 
        {
            this.length = length;
        }
    }
}
