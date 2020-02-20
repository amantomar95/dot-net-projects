using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.NETMVCCRUD.Models;

namespace asp.NETMVCCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
         using(DBmodel db = new DBmodel())
            {
                List<Employee> emplist = db.Employees.ToList<Employee>();
             return Json(new{data = emplist},JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult AddorEdit(int id = 0)
        { 
        return View(new Employee());
        }


        [HttpPost]
        public ActionResult AddorEdit(Employee emp)
        {
            using(DBmodel db= new DBmodel())
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return null;//Json(new {succes = true, message = "Save succesfully" } JsonRequestBehavior,AllowGet);
                
            }
           
        }


        public JsonRequestBehavior AllowGet { get; set; }
    }
}