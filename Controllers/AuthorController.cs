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

        
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = _authourService.GetAuthor(id.Value);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        
        [HttpPost]
        public IActionResult Edit(int id, Author author)
        {
            if (id != author.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _authourService.UpdateAuthor(author);
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

       [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = _authourService.GetAuthor(id.Value);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            _authourService.DeleteAuthor(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
