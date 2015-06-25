using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Tests
{
    public class Calculatrice
    {
        private IOperation[] globalFinalTestIOperation;

        public Calculatrice(IOperation[] globalFinalTestIOperation)
        {
            // TODO: Complete member initialization
            this.globalFinalTestIOperation = globalFinalTestIOperation;
        }

        internal object Calculer(string p)
        {
            foreach (var operation in globalFinalTestIOperation)
            {
                if (operation.PeutCalculer(p))
                    return (operation.Calculer(p));
            }
            return 0;
        }
    }
}
