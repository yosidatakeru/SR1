﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Dog
    {
        private bool hungryState;


        public Dog()
        {
            hungryState = true;
        }
        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false;
        }

        public void Run() 
        {
            Console.WriteLine("わんわん");
            hungryState = true;
        }

        public bool InHungry()
        {
            return hungryState;
        }
    }
}
