using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSB_SQL.Controllers
{
    public class RSBController : Controller
    {
        // GET: Home
        public ActionResult Index(string SearchString)
        {
            RSBEntities entities = new RSBEntities();
            if (string.IsNullOrEmpty(SearchString))
            {
                return View(from RSBDiary in entities.RSBDiary.Take(10)
                            select RSBDiary);

            } else
            {
                return View(from RSBDiary in entities.RSBDiary.Where(s=>s.case_no.ToUpper().Contains(SearchString.ToUpper()))
                            select RSBDiary);

            }
        }

   
        public ActionResult About()
        {
            ViewBag.Message = "This application is used to view the archived RSB data.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RSBDiaryDetails(int CaseID)
        {
            RSBEntities entities = new RSBEntities();
            var rsbDiaryDetail = 
                from RSBDiary in entities.RSBDiary.Where(s => s.id.Equals(CaseID))
                                 select RSBDiary;
            return View(rsbDiaryDetail.FirstOrDefault());
            //return View();
        }
    }
}