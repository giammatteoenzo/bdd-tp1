using System;

namespace Calculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return this.FirstNumber + this.SecondNumber;
        }
        
        public int Multiply()
        {
            return this.FirstNumber * this.SecondNumber;
        }
        
        public int Divide()
        {
            if (SecondNumber == 0)
            {
                throw new Exception("Division by zero impossible");

            }
            else
            {
                return this.FirstNumber / this.SecondNumber;
            }
        }
    }
}
