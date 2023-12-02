using WebQuanAn.DataAccess.Repository.IRepository;
using WebQuanAn.Models;
using WebQuanAn.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebQuanAn.ViewComponents
{
    public class GetCategoryViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetCategoryViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _unitOfWork.Category.GetAll();
            return View(categories);
        }
    }
}
