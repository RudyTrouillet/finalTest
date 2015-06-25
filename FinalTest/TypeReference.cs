using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class TypeReference
    {
        private int p;

        public TypeReference(int p)
        {
            // TODO: Complete member initialization
            this.p = p;

        }
        public override bool Equals(object obj)
        {
            return((TypeReference)obj).p == this.p;
        }
    }
}
