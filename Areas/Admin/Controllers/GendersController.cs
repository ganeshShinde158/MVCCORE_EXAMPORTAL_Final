using Microsoft.AspNetCore.Mvc;
using MVCCORE_EXAMPORTAL_Final.Models;

namespace MVCCORE_EXAMPORTAL_Final.Areas.Admin.Controllers
{
    public class GendersController : Controller
    {
        CoreProfileDbContext _context;
        public GendersController()
        {
           _context = new CoreProfileDbContext();
        }

        public IActionResult Index()
        {

            List<Tblgender> lst = _context.Tblgenders.ToList();
            return View(lst);
        }
        [HttpPost]
        public string AddGenderData([FromBody] Tblgender gender)
        {
            _context.Tblgenders.Add(gender);
            _context.SaveChanges();
            return "Gender Added Successfully";
        }
    }
}
