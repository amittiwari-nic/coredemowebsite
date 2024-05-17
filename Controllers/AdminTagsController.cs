using coredemowebsite.Data;
using coredemowebsite.Models.Domain;
using coredemowebsite.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace coredemowebsite.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly blogDbContext _dataContext;
        public AdminTagsController(blogDbContext dataContext)
        {
                this._dataContext = dataContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagReq model)
        {
            var tag = new Tag
            {
                Name=model.Name,DisplayName=model.DisplayName
            };
            _dataContext.Tags.Add(tag);
            _dataContext.SaveChanges();
            return View("Add");
        }
    }
}
