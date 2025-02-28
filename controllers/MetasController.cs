using RunGymFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace RunGymFront.controllers
{
    public class MetasController : Controller 
    {
        public ActionResult Metas()
        {
            return View();
        }
    }
}