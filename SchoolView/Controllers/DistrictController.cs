using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolView.Models;

namespace SchoolView.Controllers
{
    public class DistrictController : Controller
    {
        KUDEREntities db = new KUDEREntities();

        public ActionResult Index()
        {
            var viewModel = new DistrictViewModel()
            {
                Districts = new SelectList(db.Districts.ToList(), "leaID", "name")
            };
            return View(viewModel);
        }

        public JsonResult GetDistrictInfo(string id)
        {
            var selectedDistrict = id;
            var districtResult = getDistrict(selectedDistrict);
            return Json(districtResult, JsonRequestBehavior.AllowGet);
        }
       
        public ActionResult Query(DistrictViewModel model)
        {
            var school = getQuery(model.SelectedDistrict);
            var viewModel1 = new SchoolViewModel()
            {
                schoolList = school.ToList()
                
            };
           
            return View(viewModel1);
        }

        internal IQueryable<School> getQuery(string sd)
            {
                var query = from School in db.Schools
                            where School.leaID.Equals(sd)
                            select School;
                return query;
            }

        internal IQueryable<District> getDistrict(string id)
        {
            var query = from District in db.Districts
                        where District.leaID.Equals(id)
                        select District;
            return query;
        }
    }
}

