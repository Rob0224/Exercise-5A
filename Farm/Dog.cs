using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Dog : Animals
    {
        public Dog()
        {
            name = "Rover";
            feet = 4;
            sex = "Male";
            food = "spam";
            noise = "Bark";
            species = "Dog";
        }
    }
}