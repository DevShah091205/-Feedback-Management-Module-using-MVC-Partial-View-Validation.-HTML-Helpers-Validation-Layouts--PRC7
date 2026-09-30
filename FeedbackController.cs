using FeedbackManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackManagementMVC.Controllers
{
    public class FeedbackController : Controller
    {
        // Simple in-memory storage for this college practical.
        private static readonly List<Feedback> FeedbackList = new();

        public IActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", feedback);
            }

            feedback.SubmittedOn = DateTime.Now;
            FeedbackList.Add(feedback);

            TempData["SuccessMessage"] = "Thank you! Your feedback has been submitted.";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult List()
        {
            return View(FeedbackList);
        }
    }
}
