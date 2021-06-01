using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Square : Rectangle
    {
        private readonly string name;
        private double length;

        //TO DO: дичь в конструкторе. исправить.
        public Square(double length) : base(height: length, width: length)
        {
            this.length = length;
        }
    }
}
