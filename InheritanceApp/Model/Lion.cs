using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Lion: Animal
    {
        public void Eat()
        {
            Console.WriteLine("Lion is eating...");
        }
        public void Sound()
        {
            Console.WriteLine("Lion Roars....");
        }
    }
}
