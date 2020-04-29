using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedObject
{
    public abstract class CObject
    {
        protected int handle;

        public int Handle { get => handle; set => handle = value; }

        internal void CreateObject(string strClassName)
        {
            Handle = CObjectManager.CreateRemoteObject(strClassName);

        }

        public string this [string strAttributeName]
        {
            get
            {
                return GetAttributeValue(strAttributeName);
            }

            set
            {
                SetAttributeValue(strAttributeName, value);
            }
        }

        protected bool SetAttributeValue(string strAttributeName, string value)
        {
            return CObjectManager.SetAttributeValue(handle, strAttributeName, value );
        }

        protected string GetAttributeValue(string strAttributeName)
        {
            return CObjectManager.GetAttributeValue(handle, strAttributeName);
        }

        public string ExecuteMethod(string strMethodName, string strParams)
        {
            return CObjectManager.ExecuteMethod(handle, strMethodName, strParams);
        }
    }
}