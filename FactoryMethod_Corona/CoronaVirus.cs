using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Corona
{
    public abstract class CoronaVirus
    {
		public string Gen;
		public string Host;

		public abstract CoronaVirus Create();
    }
}