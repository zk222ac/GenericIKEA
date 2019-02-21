using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIKEA
{
    class Snoolma : AiKeaKit<Chair>
    {
        public override string Title
        {
            get { return "soolma"; }
        }

        public override string Colour
        {
            get { return "Color"; }
        }
    }
}
