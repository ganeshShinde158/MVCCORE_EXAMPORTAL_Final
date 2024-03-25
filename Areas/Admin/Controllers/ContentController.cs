using Microsoft.AspNetCore.Mvc;
using MVCCORE_EXAMPORTAL_Final.Models;

namespace MVCCORE_EXAMPORTAL_Final.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        CoreProfileDbContext _context;

        public ContentController()
        {
            _context = new CoreProfileDbContext();
        }

        public IActionResult Index()
        {
            List<TblTopicContent> lst = _context.TblTopicContents.ToList();
            return View(lst);
        }

        [HttpPost]
        public string AddContentData([FromBody] TblTopicContent content)
        {
            _context.TblTopicContents.Add(content);
            _context.SaveChanges();
            return "Content Added Successfully";
        }
    }
}
