namespace LiveCodingEditor.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using LiveCodingEditor.Models;
    using LiveCodingEditor.Services;

    using static WebConstants;

    public class HomeController : Controller
    {
        private readonly IHtmlService htmlService;

        public HomeController(IHtmlService htmlService)
        {
            this.htmlService = htmlService;
        }

        [HttpGet]
        public IActionResult Index(string id = null)
        {
            if(id != null)
            {
                if (htmlService.IdExists(id))
                {
                    var model = htmlService.GetModelById(id);
                    return View(model);
                }
                TempData[GlobalErrorKey] = "Invalid code example URL";
                RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(CodeEditorFormModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Id != null && model.QueryType == "save")
            {
                string exampleId = htmlService.Edit(model.Id, model.CodeText);
                TempData[GlobalMessageKey] = "Example was edited successfully!";

                return RedirectToAction(nameof(Index), new { id = exampleId });
            }

            if (model.QueryType == "checkOriginal")
            {
                if (this.htmlService.CheckOriginal(model.CodeText))
                {
                    TempData[GlobalMessageKey] = "HTML Code is original";
                }
                else
                {
                    TempData[GlobalErrorKey] = "HTML Code alreaxy exists in database";
                }

                return View(model);
            }
            else if (model.QueryType == "save")
            {
                string exampleId = htmlService.Add(model.CodeText);
                TempData[GlobalMessageKey] = "Example was added successfully!";

                return RedirectToAction(nameof(Index), new { id = exampleId });
            }

            TempData[GlobalErrorKey] = "Something went wrong. Please try again";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}