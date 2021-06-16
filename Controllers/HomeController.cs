using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PracticaN4.Data;
using PracticaN4.Models;

namespace PracticaN4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _sim;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context,SignInManager<IdentityUser> sim)
        {
            _logger = logger;
            _context = context;
            _sim = sim;
        }

        public IActionResult Index()
        {
            var memes=_context.Memes.ToList();
            return View(memes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       [Authorize]
        public IActionResult RegistroMeme(){
            return View();
        }

        [HttpPost]
        public IActionResult RegistroMeme(Meme m){
            if(ModelState.IsValid){
                _context.Add(m);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m);
        }

        public IActionResult Comentario(int id){
            var meme = _context.Memes.Find(id);
            return View(meme);
        }



        [HttpPost]
        public IActionResult IngresarComentario(Comentario c){
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Comentario");
            }
            return View(c);
        }
    }
}
