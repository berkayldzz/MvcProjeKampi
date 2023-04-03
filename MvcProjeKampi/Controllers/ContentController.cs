using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }

        Context c = new Context();
        public ActionResult GetAllContent(string p="")
        {
            // Arama işlemi

            var values = cm.GetList(p); 
           
            
            //var values = c.Contents.ToList();
            return View(values); 
        }

        public ActionResult ContentByHeading(int id) // Başlık kısmındaki yazılar butonu için.
        {
            var contentvalues = cm.GetListByHeadingID(id); 
            return View(contentvalues);
        }
    }
}