using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using Microsoft.EntityFrameworkCore;
using project.Data;

namespace project.Pages
{
  public class DeleteModel : PageModel
  {
    private readonly AppDbContext _context;
    [BindProperty]
    public Book Book { get; set; }
    public DeleteModel(AppDbContext context)
    {
      _context = context;
    }
	
	public IActionResult OnGet(int id) {
		Book = _context.Books.Find(id);
		
		if(Book == null)
			return RedirectToPage("NotFound");
		
		return Page();
	}
	
	public IActionResult OnPost()
	{
		var book = _context.Books.Find(Book.Id);
		
		if(book == null)
			return RedirectToPage("NotFound");
		
		_context.Books.Remove(book);
		_context.SaveChanges();
		
		return RedirectToPage("Index");
	}
  }
}