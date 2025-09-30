using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Enums;

namespace project.Pages
{
  public class EditModel : PageModel
  {
    private readonly AppDbContext _context;
    [BindProperty]
    public Book Book { get; set; }
    public EditModel(AppDbContext context)
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
    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
        return Page();
	
		Book.SellPrice = CalculateSellPrice(Book);

      _context.Attach(Book).State = EntityState.Modified;
      _context.SaveChanges();

      return RedirectToPage("Index");
    }
	
	public decimal CalculateSellPrice(Book book) {
		
			decimal percent = 100 - book.DiscountPercent;
			decimal price = book.Price * percent / 100;
			return price;
		}
  }
}