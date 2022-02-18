using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExmpl.Models
{
    public class DeptBal
    {
        public List<Department> GetDeptList()
        { 
            List<Department> dlist = new List<Department>();
            dlist.Add(new Department() { deptid=100,dname="Finance",loc="Mumbai",country="India"});
            dlist.Add(new Department() { deptid = 200, dname = "Sales", loc = "Belrin", country = "Germany" });
            dlist.Add(new Department() { deptid = 300, dname = "Accounts", loc = "Belgium", country = "Europe" });
            dlist.Add(new Department() { deptid = 400, dname = "Administration", loc = "Rome", country = "Italy" });
            dlist.Add(new Department() { deptid = 500, dname = "HR", loc = "Hamburg", country = "Germany" });
            dlist.Add(new Department() { deptid = 600, dname = "Marketing", loc = "Bengaluru", country = "India" });
            return dlist;
        }
    }
}