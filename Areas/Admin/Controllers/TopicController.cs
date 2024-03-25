using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCORE_EXAMPORTAL_Final.Models;

namespace MVCCORE_EXAMPORTAL_Final.Areas.Admin.Controllers
{
    public class TopicController : Controller
    {
        CoreProfileDbContext _context;
        public TopicController()
        {
            _context = new CoreProfileDbContext();
        }

        public IActionResult Index()
        {
            List<TblTopic> lst = _context.TblTopics.ToList();
            return View(lst);
        }

        [HttpPost]
        public string AddTopicData([FromBody] TblTopic topic)
        {
            _context.TblTopics.Add(topic);
            _context.SaveChanges();
            return "Qualification Added Successfully";
        }

        public JsonResult GetTopic()
        {
            List<TblTopic> TopicList = new List<TblTopic>();

            foreach (TblTopic d in _context.TblTopics.ToList())
            {
                TblTopic item = new TblTopic()
                {
                    TopicId = d.TopicId,
                    TopicName = d.TopicName,
                };

                TopicList.Add(item);
            }

            return Json(TopicList);
        }
    }
}
