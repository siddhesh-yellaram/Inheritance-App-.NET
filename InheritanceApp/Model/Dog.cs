using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Dog:Animal
    {
        public void Sound()
        {
            Console.WriteLine("Dog is barking bow bow...");
        }
    }
}
