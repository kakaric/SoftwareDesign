using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Corona
{
    public class SARS_CoV : CoronaVirus
    {
        public SARS_CoV(string host)
        {
            Host = host;
        }

        public override CoronaVirus Create()
        {
            return new SARS_CoV(this.Host);
        }
    }
}
