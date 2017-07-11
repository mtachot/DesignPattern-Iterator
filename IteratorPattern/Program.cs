using IteratorPattern.Classes;
using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            IIterator iter = namesRepository.GetIterator();
            while(iter.HasNext())
            {
                string name = iter.Next().ToString();
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
