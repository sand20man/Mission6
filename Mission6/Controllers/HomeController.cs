using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Mission6.Models;
using IActionResult = Microsoft.AspNetCore.Mvc.IActionResult;

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
        ViewBag.Category = _context.Categories.ToList();
        return View(new Movie());
    }
    
    [HttpPost]
    public IActionResult Movie(Movie movie)
    {
        _context.Movies.Add(movie); //Add Data
        _context.SaveChanges();
        return View("Confirmation");
    }
    
    public IActionResult MovieCollection()
    {
        var movies = _context.Movies
            .Include(x=>x.Category).ToList();
        return View(movies);
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
         var recordtoEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Category = _context.Categories.ToList();
        return View("Movie", recordtoEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedinfo)
    {
        _context.Update(updatedinfo);
        _context.SaveChanges();
        return RedirectToAction("MovieCollection");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordtoDelete = _context.Movies
            .Single(x => x.MovieId == id);
        return View(recordtoDelete);
    }
    
    [HttpPost]
    public IActionResult Delete(Movie deletedinfo)
    {
        _context.Movies.Remove(deletedinfo);
        _context.SaveChanges();
        return RedirectToAction("MovieCollection");
    }
        
}