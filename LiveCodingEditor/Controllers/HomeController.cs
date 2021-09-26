namespace LiveCodingEditor.Controllers
{
    using System.Diagnostics;
    using LiveCodingEditor.Models;
    using LiveCodingEditor.Services;
    using Microsoft.AspNetCore.Mvc;

    using static WebConstants;

    public class HomeController : Controller
    {
        private readonly IHtmlService htmlService;

        public HomeController(IHtmlService htmlService)
        {
            this.htmlService = htmlService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CodeEditorFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var dbInsertSucceeded = htmlService.Add(model.CodeText);
            if (!dbInsertSucceeded)
            {
                TempData[GlobalErrorKey] = "Failed to add example!";
            }
            TempData[GlobalMessageKey] = "Example was added successfully!";

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}