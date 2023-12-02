using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebQuanAn.DataAccess.Repository.IRepository;
using WebQuanAn.Models;

namespace WebQuanAn.ViewComponents
{
    public class GetNameViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public GetNameViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }
    }
}
