using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Work_Integrated_Learning.Data;
using Work_Integrated_Learning.Models;

namespace Work_Integrated_Learning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;
        private readonly IEnumerable<Presenters> _presenters;
        private readonly IEnumerable<Reviews> _reviews;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _presenters = _db.Presenters;
            _reviews = _db.Reviews;
        }

        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel
            {
                objPresenters = _presenters,
                objReviewsList = _reviews,
            };

            return View(indexViewModel);
        }

        public IActionResult Upcoming()
        {
            return View(_presenters);
        }

        public IActionResult Vouchers()
        {
            return View();
        }

        public IActionResult Reviews()
        {

            return View(_reviews);
        }

        public IActionResult Socials()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}