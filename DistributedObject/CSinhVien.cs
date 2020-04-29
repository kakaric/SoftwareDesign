using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedObject
{
    public class CSinhVien : CObject
    {
        public CSinhVien()
        {
            base.CreateObject("SStudent");

        }

        public int MSSV
        {
            get => int.Parse(GetAttributeValue("StudentID"));
            set => SetAttributeValue("StudentID", value.ToString());
        }

        public double DTB
        {
            get => double.Parse(GetAttributeValue("GPA"));
            set => SetAttributeValue("GPA", value.ToString());
        }

        public string HoTen
        {
            get => GetAttributeValue("FullName");
            set => SetAttributeValue("FullName", value);
        }

        public string Ho
        {
            get
            {
                string HoTen = GetAttributeValue("FullName");
                string[] tokens = HoTen.Split(' ');
                return tokens[0];
            }
        }

        public string XepLoaiHocLuc
        {
            get
            {
                string strXepLoai = ExecuteMethod("GetAcademicClassification", "");
                switch (strXepLoai)
                {
                    case "Excellent": return "Xuất sắc";
                    case "Very Good": return "Giỏi";
                    case "Good": return "Khá";
                    case "Satisfactory": return "Trung bình khá";
                }
                return "";
            }
        }
    }
}