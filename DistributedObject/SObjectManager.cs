using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace DistributedObject
{
    internal class SObjectManager
    {
        private static int NextAvailableHandle = 1;
        private static Dictionary<int, SObject> objects = new Dictionary<int, SObject>();
        public static int Register(SObject sObject)
        {
            int handle = NextAvailableHandle++;
            objects.Add(handle, sObject);
            return handle;
        }

        internal static int CreateObject(string strClassName)
        {
            int handle = 0;
            SObject obj = null;
            switch(strClassName)
            {
                case "SStudent":
                    {
                        obj = new SStudent();
                        break;
                    }
            }
            if (obj != null)
                handle = obj.Handle;
            return handle;
        }

        public static string GetAttributeValue(int handle, string strAttributeName)
        {
            SObject obj = FindObjectByHandle(handle);
            if (obj == null)
                return "#N/A";
            return obj.GetAttributeValue(strAttributeName);
        }

        private static SObject FindObjectByHandle(int handle)
        {
            if (objects.ContainsKey(handle))
                return objects[handle];
            return null;
        }

        public static bool SetAttributeValue(int handle, string strAttributeName, string newValue)
        {
            SObject obj = FindObjectByHandle(handle);
            if (obj == null)
                return false;
            return obj.SetAttributeValue(strAttributeName, newValue);
        }

        public static string ExecuteMethod(int handle, string strMethodName, string strParams)
        {
            SObject obj = FindObjectByHandle(handle);
            if (obj == null)
                return "N/A";
            return obj.ExecuteMethod(strMethodName, strParams);
        }
    }
}