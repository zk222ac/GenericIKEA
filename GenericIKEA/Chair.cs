using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIKEA
{
   public class Chair : IToolKit , IParts
    {
        public string[] GetTools()
        {
            return new string[] { "Screwdriver", "Allen Key" };
        }

        public string[] GetParts()
        {
            return new string[] {
                "leg", "leg", "leg", "seat", "back", "bag of screws" };
        }
    }
}
