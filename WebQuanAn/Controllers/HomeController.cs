using WebQuanAn.DataAccess.Repository.IRepository;
using WebQuanAn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WebQuanAn.Models.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity.UI.Services;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using WebQuanAn.Utility.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;

namespace WebSoccer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotyfService _notyf;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, INotyfService notyf)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _notyf = notyf;
        }

        public IActionResult Index()
        {

            List<Product> latestProducts = _unitOfWork.Product.GetAll(includeProperties: "Category,ProductImages")
                .OrderByDescending(x => x.CreateAt).Take(4).ToList();
            var listCategory = _unitOfWork.Category.GetAll().OrderBy(x => x.CreateAt).Take(4);
            ViewBag.ListCategory = listCategory;
            return View(latestProducts);
        }
        public IActionResult Contact() {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            var msg = "Tên: " + contact.Name + "<br>";
            msg += "Email: " + contact.Email + "<br>";
            msg += "Nội dung: " + contact.Message.Replace(Environment.NewLine, "<br>");
            EmailSenderHelper.SendEmail(contact.Email, "nghuydu.99@gmail.com", contact.Subject, msg);
            _notyf.Success("Gửi phản hồi thành công!");
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult BookTable()
        {
            List<SelectListItem> numOfPepple = new List<SelectListItem>();
            numOfPepple.Add(new SelectListItem() { Text = "1 người", Value = "1" });
            numOfPepple.Add(new SelectListItem() { Text = "2 người", Value = "2" });
            numOfPepple.Add(new SelectListItem() { Text = "3 người", Value = "3" });
            numOfPepple.Add(new SelectListItem() { Text = "4 người", Value = "4" });
            numOfPepple.Add(new SelectListItem() { Text = "5 người", Value = "5" });
            numOfPepple.Add(new SelectListItem() { Text = "Khác", Value = "6" });
            ViewBag.NumberOfPeople = numOfPepple;
            return View();
        }
        [HttpPost]
        public IActionResult BookTable(BookTableVM vm)
        {
            var booktable = new BookTable()
            {
                Name = vm.Name,
                Email = vm.Email,
                PhoneNumber = vm.PhoneNumber,
                ArrivalDatetime = DateTime.ParseExact($"{vm.ArrivalDate} {vm.ArrivalTime}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                NumberOfPeople = vm.NumberOfPeople,
                Message = vm.Message,
            };
            _unitOfWork.BookTable.Add(booktable);
            _unitOfWork.Save();
            _notyf.Success("Đặt bàn thành công!");
            return View();
        }
    }
}