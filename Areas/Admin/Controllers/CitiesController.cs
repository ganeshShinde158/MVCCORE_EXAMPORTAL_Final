using Microsoft.AspNetCore.Mvc;
using MVCCORE_EXAMPORTAL_Final.Models;

namespace MVCCORE_EXAMPORTAL_Final.Areas.Admin.Controllers
{
    public class CitiesController : Controller
    {
        CoreProfileDbContext _context;

        public CitiesController()
        {
            _context = new CoreProfileDbContext();
        }
        public IActionResult Index()
        {
            List<Tblcity> lst = _context.Tblcities.ToList();
            return View(lst);
        }
        [HttpPost]
        public string AddCityData([FromBody] Tblcity city)
        {
            _context.Tblcities.Add(city);
            _context.SaveChanges();
            return "City Added Successfully";
        }
        public JsonResult GetCities()
        {
            List<Tblcity> cityList = new List<Tblcity>();

            foreach (Tblcity d in _context.Tblcities.ToList())
            {
                Tblcity item = new Tblcity()
                {
                    CityId = d.CityId,
                    CityName = d.CityName,
                };

                cityList.Add(item);
            }

            return Json(cityList);
        }
    }
}
