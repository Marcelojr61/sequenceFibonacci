using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math

    {
        public List<int> Fibonnaci()
        {
            List<int> newNumber = new List<int> { 0 };

            int number = 0, controller = 1;

            while (number <= 350)
            {
                number = number + controller;
                if (number > 350) { break; }
                newNumber.Add(number);
                controller = number - controller;
            }
            return newNumber;
        }
        public bool IsFibonnaci(int inputNumber)
        {
            return Fibonnaci().Contains(inputNumber);

        }
    }
}
