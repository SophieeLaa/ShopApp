using Microsoft.AspNetCore.Mvc;
using ShopProject.Data;
using ShopProject.Models;

namespace ShopProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext  db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
