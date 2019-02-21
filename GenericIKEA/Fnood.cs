using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIKEA
{
   public class Fnood : AiKeaKit<Chair>
    {
        // concrete implemnation
        public override string Title
        {
            get { return "Fnood"; }
        }
        public override string Colour
        {
            get { return "Red"; }
        }
    }
}
