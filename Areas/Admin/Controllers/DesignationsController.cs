using Microsoft.AspNetCore.Mvc;
using MVCCORE_EXAMPORTAL_Final.Models;

namespace MVCCORE_EXAMPORTAL_Final.Areas.Admin.Controllers
{
    public class DesignationsController : Controller
    {
        CoreProfileDbContext _context;
        public DesignationsController()
        {
            _context = new CoreProfileDbContext();
        }
        public IActionResult Index()
        {
            List<Tbldesignation> lst = _context.Tbldesignations.ToList();
            return View(lst);
        }
        [HttpPost]
        public string AddDesignationData([FromBody]Tbldesignation designation)
        {
            _context.Tbldesignations.Add(designation);
            _context.SaveChanges();
            return "Designation Added Successfully";
        }
        public JsonResult GetDesignations()
        {
            List<Tbldesignation> designationList = new List<Tbldesignation>();

            foreach (Tbldesignation d in _context.Tbldesignations.ToList())
            {
                Tbldesignation item = new Tbldesignation()
                {
                    DesignationId = d.DesignationId,
                    DesignationName = d.DesignationName,
                };

                designationList.Add(item);
            }

            return Json(designationList);
        }

    }
}
