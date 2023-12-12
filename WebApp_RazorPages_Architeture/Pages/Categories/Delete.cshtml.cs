using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_Architeture.Data;
using WebApp_RazorPages_Architeture.Models;

namespace WebApp_RazorPages_Architeture.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Category category { get; set; }
        public DeleteModel(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                category = _dbContext.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
            TempData["Success"] = "Deleted Succesfully";
            return RedirectToPage("Index", "Categories");
        }
    }
}
