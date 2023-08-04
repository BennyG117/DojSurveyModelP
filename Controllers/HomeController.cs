using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojSurveyModelP.Models;

namespace DojSurveyModelP.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    //! list of surveys
    public static List<Survey> Surveys = new List<Survey>();


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //! Index
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    //! Create
        [HttpPost("submission/create")]
    //add parameters
    public IActionResult Create(Survey newSurvey)
    {
        if(ModelState.IsValid)
        {
        Surveys.Add(newSurvey);
        return RedirectToAction("AllSurveys");
        } else {
            return View("Index");
        }
    }



    //!Get All Surveys
    [HttpGet("allsurveys")]
    //Adding ", pets" as the list of pets
    public IActionResult AllSurveys()
    {
        return View("AllSurveys", Surveys);
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
