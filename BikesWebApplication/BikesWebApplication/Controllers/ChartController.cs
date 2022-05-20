using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikesWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly DBLytvynenkoContext _context;
        public ChartController(DBLytvynenkoContext context)
        {
            _context = context;
        }

        [HttpGet("JsonData")]
        public JsonResult JsonData()
        {
            var cities = _context.Cities.ToList();
            List<object> cityShop = new List<object>();
            cityShop.Add(new[] { "Місто", "Кількість магазинів" });
            foreach (var c in cities)
                cityShop.Add(new object[] { c.Name, c.Shops.Count() });
            return new JsonResult(cityShop);
        }
    }
}

