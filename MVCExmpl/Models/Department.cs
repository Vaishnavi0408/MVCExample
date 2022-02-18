using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExmpl.Models
{
    public class Department
    {
        public int deptid { get; set; }
        public string dname { get; set; }
        public string loc { get; set; }
        public string country { get; set; }
    }
}