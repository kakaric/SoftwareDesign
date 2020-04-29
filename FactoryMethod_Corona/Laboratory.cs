using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Corona
{
    public class Laboratory
    {
        protected Dictionary<string, CoronaVirus> prototypes = null;
        public void InitLaboratory()
        {
            prototypes = new Dictionary<string, CoronaVirus>();
            prototypes.Add("Sars-CoV in human", new SARS_CoV("Human"));
            prototypes.Add("Sars-CoV in mammal", new SARS_CoV("Mammal"));

            prototypes.Add("Sars-CoV-2 in human", new SARS_CoV_2("Human"));
            prototypes.Add("Sars-CoV-2 in mammal", new SARS_CoV_2("Mammal"));
        }

        public CoronaVirus Create(string strCoronaVirusType)
        {
            if (prototypes.ContainsKey(strCoronaVirusType))
                return prototypes[strCoronaVirusType].Create(); // Clone
            return CreateDefaultAppropriateType();
        }

        public CoronaVirus CreateWithComplexCriteria(CreateRequirement req)
        {
            foreach (string s in prototypes.Keys)
                //if (prototypes[s].IsSatisfied(req))
                if (req.IsOK(prototypes[s])) // strategy
                    return prototypes[s].Create();
            return CreateDefaultAppropriateType();
        }

        public CoronaVirus CreateDefaultAppropriateType()
        {
            // dummy implementation
            foreach (string s in prototypes.Keys)
                return prototypes[s].Create();
            return null;
        }
    }
}