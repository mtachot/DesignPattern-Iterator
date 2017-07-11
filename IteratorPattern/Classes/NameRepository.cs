using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    public class NameRepository : IContainer
    {
        public static string[] names = { "Robert", "John", "Julie", "Laura" };

        public IIterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            int index;

            public bool HasNext()
            {
                if (index < names.Length)
                    return true;
                else
                    return false;
            }

            public object Next()
            {
                if (this.HasNext())
                    return names[index++];
                else
                    return null;
            }
        }
    }
}
