using Microsoft.AspNetCore.Mvc;
using MVCCORE_EXAMPORTAL_Final.Models;

namespace MVCCORE_EXAMPORTAL_Final.Areas.Admin.Controllers
{
    public class QualificationController : Controller
    {
        CoreProfileDbContext _context;
        public QualificationController()
        {
            _context = new CoreProfileDbContext();
        }

        public IActionResult Index()
        {
            List<Tblqualification> lst = _context.Tblqualifications.ToList();
            return View(lst);
        }
        [HttpPost]
        public string AddQualificationData([FromBody] Tblqualification qualification)
        {
            _context.Tblqualifications.Add(qualification);
            _context.SaveChanges();
            return "Qualification Added Successfully";
        }
        public JsonResult GetQualification()
        {
            List<Tblqualification> QualificationList = new List<Tblqualification>();

            foreach (Tblqualification d in _context.Tblqualifications.ToList())
            {
                Tblqualification item = new Tblqualification()
                {
                    QualificationId = d.QualificationId,
                    Qualification = d.Qualification,
                };

                QualificationList.Add(item);
            }

            return Json(QualificationList);
        }
    }
}
