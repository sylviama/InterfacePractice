using zoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    interface IAnimal
    { 
        string Sound();
        int Age();
    }

    class Animal: IAnimal
    {
        public string Sound()
        {
            return "Meow";
        }

        public int Age()
        {
            return 2;
        }
    }



    class Program
    {
        static void Main()
        {
            Animal cat = new Animal();
            string cat_sound=cat.Sound();
            cat.Age();
            Console.WriteLine(cat_sound);
        }
    }
}
