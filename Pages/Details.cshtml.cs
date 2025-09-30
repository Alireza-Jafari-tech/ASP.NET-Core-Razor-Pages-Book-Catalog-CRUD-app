using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using Microsoft.EntityFrameworkCore;
using project.Data;

namespace project.Pages
{
  public class DetailsModel : PageModel
  {
    private readonly AppDbContext _context;
    [BindProperty]
    public Book Book { get; set; }
    public DetailsModel(AppDbContext context)
    {
      _context = context;
    }

    public IActionResult OnGet(int id)
    {
      Book = _context.Books.Find(id);

      if (Book == null)
        return RedirectToPage("NotFound");

      return Page();
    }
  }
}