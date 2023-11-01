using LibraryMvcOdev_1.Models.Authors.PageVms;
using LibraryMvcOdev_1.Models.Authors.PureVms;
using LibraryMvcOdev_1.Models.Authors.RequestModels;
using LibraryMvcOdev_1.Models.Authors.ResponseModels;
using LibraryMvcOdev_1.Models.ContextClasses;
using LibraryMvcOdev_1.Models.Entites;
using LibraryMvcOdev_1.Models.MapperClasses;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMvcOdev_1.Controllers
{
    public class AuthorController : Controller
    {
        MyContext _db;
        public IActionResult Index()
        {
            return View();
        }
        public AuthorController(MyContext db)
        {
            _db = db;
        }
        public IActionResult CreateAuthor() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAuthor(CreateAuthorRequestModel author) 
        {
            Author a = new()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
            };
            _db.Authors.Add(a);
            _db.SaveChanges();
            return View();
        }
        public IActionResult GetAuthors() 
        {
            List<AuthorResponseModel> authors = _db.Authors.Select(x=> new AuthorResponseModel 
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();

            AuthorResponsePageVM apVm = new AuthorResponsePageVM
            {
                Authors = authors
            };
              

            
            return View(apVm);
        }
        public IActionResult UpdateAuthor(int id)
        {
            AuthorVM author = AuthorMapper.GetAuthorVM(_db.Authors.Find(id));

            AuthorSharedPageVM apVm = new()
            {
                Author = author,
            };
            return View(apVm);
        }
        [HttpPost]
        public IActionResult UpdateAuthor(AuthorVM author)
        {
            Author original = _db.Authors.Find(author.ID);
            original.FirstName = author.FirstName;
            original.LastName = author.LastName;
            _db.SaveChanges();
            TempData["message"] = "Guncelleme Basarili";
            return RedirectToAction("GetAuthors");
        }

        public IActionResult DeleteCategory(int id)
        {
            _db.Authors.Remove(_db.Authors.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetAuthors");
        }
    }
}
