using IDGS902_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OperasBas(string n1, string n2) {
            int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }
        public ActionResult OperasBas2(Calculos op)
        {
            var model=new Calculos();
            model.Res = op.Num1 + op.Num2;
            ViewBag.Res = model.Res;
            return View(model);
        }
    }

}