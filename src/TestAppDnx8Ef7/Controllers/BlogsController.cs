using TestAppDnx8Ef7.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace TestAppDnx8Ef7.Controllers
{
    public class BlogsController: Controller
    {
        private BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }

        // Nicky: Index action, which displays all blogs in the database
        public IActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }

        //Nicky: Returns the Create view.
        public IActionResult Create()
        {
            return View();
        }

        // Nicky: Create action, which inserts a new blog into the database.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Blogs.Add(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

    }
}

    }
}