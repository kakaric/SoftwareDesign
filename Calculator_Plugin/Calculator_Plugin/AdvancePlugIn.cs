using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Plugin
{
    public class AdvancePlugIn : Plugin.Plugin
    {
        public double sqrOperator(object a)
        {
            try
            {
                double x = (double)a;
                return x * x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double sqrtOperator(object a)
        {
            try
            {
                double x = (double)a;
                return sqrtOperator(x);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
