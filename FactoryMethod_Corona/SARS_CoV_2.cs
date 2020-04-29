using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Corona
{
    public class SARS_CoV_2 : CoronaVirus
    {
        public SARS_CoV_2(string host)
        {
            Host = host;
        }

        public override CoronaVirus Create()
        {
            return new SARS_CoV_2(this.Host);
        }
    }
}
