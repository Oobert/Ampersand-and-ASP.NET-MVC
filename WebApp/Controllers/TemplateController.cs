using RazorEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class TemplateController : Controller
    {
        
        public ActionResult TemplateJS()
        {
            Response.ContentType = "text/javascript";
            return View();
        }

        public string RenderRazorViewToString(string viewPath)
        {
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "views\\template\\"+viewPath);
            string template = System.IO.File.ReadAllText(filepath);

            return Razor.Parse(template).Replace("\r", "").Replace("\n", "").Replace("\"", "\\\"").Trim();         
        }
        
    }
}