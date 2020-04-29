using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Corona
{
    public class CreateRequirement
    {
        public virtual bool IsOK(CoronaVirus coronaVirus)
        {
            return true;
        }
    }
}
