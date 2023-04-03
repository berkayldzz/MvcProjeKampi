using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        ContentManager cm = new ContentManager(new EfContentDal());
        Context c = new Context();
        public ActionResult MyContent(string p)
        {
           
            p = (string)Session["WriterMail"]; // Hangi yazarla giriş yapılırsa onun mesajlarını/bilgilerini getir.
            var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();  // Girdiğim mailin idsini getir.
            var contentvalues = cm.GetListByWriter(writeridinfo); // O idye göre de bilgileri getir.
            return View(contentvalues);
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"]; // Hangi yazarla giriş yapılırsa onun mesajlarını/bilgilerini getir.
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();    

            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.ContentAdd(p);
            p.WriterID = writeridinfo;
            p.ContentStatus = true;
            return RedirectToAction("MyContent");
        }
        public ActionResult ToDoList()
        {
            return View();  
        }


    }
}