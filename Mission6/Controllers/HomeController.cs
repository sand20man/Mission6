using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    private ApplicationDbContext _context;
    public HomeController(ApplicationDbContext temp)
    {
        _context = temp; 
    }
    public IActionResult JHilton()
    {
        return View("JHilton");
    }
    public IActionResult Info()
    {
        return View("Info");
    }
    
    [HttpGet]
    public IActionResult Movie()
    {
        return View("Movie");
    }
    
    [HttpPost]
    public IActionResult SaveMovie(Movie movie)
    {
        _context.Movies.Add(movie); //Add Data
        _context.SaveChanges();
        return View("Confirmation");
    }
}