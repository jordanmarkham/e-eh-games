﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LetterMatch.Models;

namespace LetterMatch.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("/")]
    [HttpGet]
    public IActionResult Index()
    {
      if(HttpContext.Request.Query["name"] == "missing"){
        ViewBag.message = "Please provide a Player Name to get started!";
      }
      return View();
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
}
