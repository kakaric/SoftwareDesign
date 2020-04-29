using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DistributedObject
{
    public class SStudent : SObject
    {
        protected int StudentID;
        protected string FullName;
        protected double GPA;

        public override string GetAttributeValue(string strAttributeName)
        {
            switch (NormalizeAttributeName(strAttributeName))
            {
                case "StudentID":
                    return StudentID.ToString();
                case "FullName":
                    return FullName;
                case "GPA":
                    return GPA.ToString();
            }
            return "";
        }

        public override bool SetAttributeValue(string strAttributeName, string newValue)
        {
            try
            {
                switch (NormalizeAttributeName(strAttributeName))
                {
                    case "StudentID":
                        StudentID = int.Parse(newValue);
                        return true;
                    case "FullName":
                        FullName = newValue;
                        return true;
                    case "GPA":
                        return setGPA(double.Parse(newValue));
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool setGPA(double v)
        {
            if (v >= 0 && v <= 10)
            {
                GPA = v;
                return true;
            }
            return false;
        }

        public override string ExecuteMethod(string strMethodName, string strParams)
        {
            switch (NormalizeMethodName(strMethodName))
            {
                case "GetAcademicClassification":
                    return GetAcademicClassification(strParams);
            }
            return "";
        }

        private string GetAcademicClassification(string strParams)
        {
            if (GPA >= 9)
                return "Excellent";
            else if (GPA >= 8)
                return "Very Good";
            else if (GPA >= 7)
                return "Good";
            else if (GPA >= 5)
                return "Satisfactory";
            return "";
        }
    }
}