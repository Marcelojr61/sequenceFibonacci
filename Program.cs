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

            while (number + controller <= 350)
            {
                number = number + controller;
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
