using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using Work_Integrated_Learning.Data;
using Work_Integrated_Learning.Models;

namespace Work_Integrated_Learning.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;
        private readonly ApplicationDbContext _db;

        public RegisterController(ILogger<RegisterController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult RegisterOneManArmy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterWeekend()
        {
            return View();
        }

        public IActionResult RegistrationSuccess(string voucherId)
        {
            return View((object)voucherId);
        }

        public IActionResult RegistrationFailed(string message)
        {
            return View((object)message);
        }

        [HttpPost]
        public IActionResult YouAnd5Register(string username, string email)
        {
            return HandleRegistration(username, email, "1");
        }

        [HttpPost]
        public IActionResult WeekendXpRegister(string username, string email)
        {
            return HandleRegistration(username, email, "2");
        }


        [HttpPost]
        public IActionResult OneManArmyRegister(string username, string email)
        {
            return HandleRegistration(username, email, "3");
        }

        private IActionResult HandleRegistration(string username, string email, string voucherId)
        {
            var existingUsername = _db.Users.FirstOrDefault(u => u.Username == username);
            var existingEmail = _db.Users.FirstOrDefault(u => u.Email == email);

            if (!IsValid(email))
            {
                return RedirectToAction("RegistrationFailed", new { message = "Sorry, but you entered an invalid email." });
            }

            if (existingUsername != null && existingEmail != null)
            {
                return RedirectToAction("RegistrationFailed", new { message = "Sorry, but your already coming. You have already redeemed a voucher." });
            }

            if (existingUsername != null)
            {
                return RedirectToAction("RegistrationFailed", new { message = "Username is taken." });
            }

            if (existingEmail != null)
            {
                return RedirectToAction("RegistrationFailed", new { message = "Email already exists." });
            }

            var user = new User
            {
                Username = username,
                Email = email,
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return RedirectToAction("RegistrationSuccess", new { voucherid = voucherId });
        }

        private bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress email = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
