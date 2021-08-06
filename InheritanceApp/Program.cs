using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceApp.Model;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal eat method will directly be called because a1 is instance of animal
            Animal a1 = new Dog();
            a1.Eat();
            //a1.Sound(); //This will not word since animals have different sounds

            //Same case as above for Lion too
            Animal a4 = new Lion();
            a4.Eat();

            //Lion has eat method so animal eat method will not be called
            Lion a2 = new Lion();
            a2.Eat();
            a2.Sound();

            //Dog does not have eat method so animal eat method will be called
            Dog a3 = new Dog();
            a3.Eat();
            a3.Sound();

            Console.ReadLine();
        }
    }
}
