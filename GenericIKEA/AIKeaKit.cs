using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIKEA
{
   public abstract class AiKeaKit<T> where T : IToolKit , IParts , new()
    {
        public abstract string Title
        {
            get;
        }

        public abstract string Colour
        {
            get;
        }

        public void GetInventory()
        {
            var content = new T();
            foreach (var tool in content.GetTools())
            {
                Console.WriteLine($"Tools- {tool}");
            }
            foreach (var part in content.GetParts())
            {
                Console.WriteLine($"Parts- {part}");
            }

        }


    }
}
