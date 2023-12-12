using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_Architeture.Data;
using WebApp_RazorPages_Architeture.Models;

namespace WebApp_RazorPages_Architeture.Pages.Categories
{
    public class IndexModel : PageModel // this is  like the controller class that it is linked with the view
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public List<Category> categoriesList { get; set; }
        public IndexModel(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }
        public void OnGet()
        {
            categoriesList=_applicationDbContext.Categories.ToList();
        }
    }
}
