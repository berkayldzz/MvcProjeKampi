using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        // BusinessLayer da oluşturduğum sınıfımı çağırmam gerek.

        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            

            // CategoryValidator u burda çağırıyorum ki şartlarım uygulansın

            CategoryValidator categoryValidatior = new CategoryValidator();
            // Validasyon sonuçlarını tutucak olan komutumu ekliyorum
            ValidationResult results = categoryValidatior.Validate(p); // CategoryValidatior sınıfında olan değerlere göre doğrulama işlemi yap.
            if(results.IsValid) // Eğer sonuç validasyona uygunsa geçerliyse
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                // hata mesajları yansıtma
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View();
        }
    }
}