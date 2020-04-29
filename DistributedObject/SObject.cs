using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedObject
{
    public abstract class SObject
    {
        protected int handle;

        public int Handle { get => handle; set => handle = value; }

        public SObject()
        {
            Handle = SObjectManager.Register(this);
        }

        public virtual string GetAttributeValue(string strAttributeName)
        {
            return "";
        }

        public virtual bool SetAttributeValue(string strAttributeName, string newValue)
        {
            return false;
        }

        protected virtual string NormalizeAttributeName(string strAttributeName)
        {
            //return AttributeNameNormalizer.Process(strAttributeName);
            return strAttributeName; // dummy implementation
        }

        public virtual string ExecuteMethod(string strMethodName, string strParams)
        {
            return "";
        }

        protected string NormalizeMethodName(string strMethodName)
        {
            return strMethodName; //dummy implementation
        }
    }
}