using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Workshops
{
    public class HoomanClass
    {
        // Attributes
        public string name;
        public int age;
        public bool hasDog;
        public string dogName;
        public bool hasToPoop;

        //Methods

        public void Greeting() 
        {
            if (hasDog == true)
            {
                Console.WriteLine($"Hello {name}. Nice to meet you. I see you have a dog named {dogName}. Cool name bro. It's nice to see someone at the age of {age} that has a dog.");
            }
            else 
            {
                Console.WriteLine($"What {name}!!! You don't own a dog? Someone {age} years old, should really own a dog.");
            }
        }
    }
}


