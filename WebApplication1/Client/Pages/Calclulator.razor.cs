using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Client.Pages
{
    public partial  class Calclulator
    {
        public string Evaluate(string expression)
        {
            // cannot begin with multiplication
            // cannot have multiplication and division together
            // multiplication or division cannot be second operator 
            // cannot end with an operator

            //char first = expression[0];

            //if (!Char.IsDigit(first))
            //{
            //    if (first == 'x')

            //    return "err";
            try
            {
                DataTable dt = new DataTable();

                var result = dt.Compute(expression, "");

                return result.ToString();
            }
            catch(Exception e)
            {
                return "err";
            }
            
            
        }
    }
}
