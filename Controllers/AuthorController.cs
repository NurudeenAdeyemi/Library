using Library.Interface.Services;
using Library.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authourService;

        public AuthorController(IAuthorService authorService)
        {
            _authourService = authorService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /*var authorList = _authourService.GetAll();
            return View(authorList);*/
            return View(_authourService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                _authourService.AddAuthor(author);
            }
            //return View();
            return RedirectToAction(nameof(Index));
            
        }
    }
}
