using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedObject
{
    public class CObjectManager
    {
        internal static bool SetAttributeValue(int handle, string strAttributeName, string value)
        {
            return SObjectManager.SetAttributeValue(handle, strAttributeName, value);
        }

        internal static int CreateRemoteObject(string strClassName)
        {
            return SObjectManager.CreateObject(strClassName);
        }

        internal static string GetAttributeValue(int handle, string strAttributeName)
        {
            return SObjectManager.GetAttributeValue(handle, strAttributeName);
        }

        internal static string ExecuteMethod(int handle, string strMethodName, string strParams)
        {
            return SObjectManager.ExecuteMethod(handle, strMethodName, strParams);
        }
    }
}