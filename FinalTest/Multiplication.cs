using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Multiplication : FinalTest.IOperation
    {
       public bool PeutCalculer(string calcul)
       {
           return (calcul.Contains("*"));
       }
       public int Calculer(String calcul)
       {
           var splitted = new string[2];
           splitted=calcul.Split('*');
           return Convert.ToInt32(splitted[0]) * Convert.ToInt32(splitted[1]);
       }
    }
}
