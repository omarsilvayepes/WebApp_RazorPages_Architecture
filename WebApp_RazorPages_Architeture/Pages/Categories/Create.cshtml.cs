using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_Architeture.Data;
using WebApp_RazorPages_Architeture.Models;

namespace WebApp_RazorPages_Architeture.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Category category { get; set; }
        public CreateModel(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public IActionResult OnPost()
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Name Can Not exactly match with the Display Order Field");
            }
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
                TempData["Success"] = "Create Succesfully";
                return RedirectToPage("Index", "Categories");
            }
            return Page();
        }
    }
}
