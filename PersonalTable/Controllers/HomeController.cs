using PersonalTable.Context;
using PersonalTable.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static PersonalTable.Models.Visitor;

namespace PersonalTable.Controllers
{
    public class HomeController : Controller
    {
       protected Visitors db = new Visitors();
        public ActionResult Index()
        {
          
            return View();
        }

      
        public ActionResult AddVisitor(Visitor visitor, HttpPostedFileBase Photo)
        {
           
            
            visitor.Enter = DateTime.Now;
            visitor.Exit = DateTime.Now;
            
            if (Photo != null)
            {
                string photoName = "";
                string image = "";
                photoName = DateTime.Now.ToString("yyyyMMddHHmmss") + Photo.FileName;
                image = Path.Combine(Server.MapPath("~/Uploads"), photoName);

                Photo.SaveAs(image);
                visitor.Photo = photoName;
            }
            db.Visitor.Add(visitor);
            db.SaveChanges();

          return  RedirectToAction("Index");

        }
    }
       
}