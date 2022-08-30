using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Academy.Models
{
    public class Group
    {
        public string GroupCode { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }

        public static int code = 100;
        public Group(string education)
        {
            GroupCode = education.ToUpper()[0] + code.ToString();
            code++;
        }
       


    }
}
