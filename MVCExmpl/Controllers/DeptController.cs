﻿using MVCExmpl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCExmpl.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            DeptBal db = new DeptBal();
            List<Department> list = db.GetDeptList();
            TempData["deplist"] = list;
            return View();
        }
    }
}