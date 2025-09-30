using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Model;
using project.Data;

namespace project.Pages {
	public class CreateModel : PageModel
	{
		private readonly AppDbContext _context;
		
		[BindProperty]
		public Book Book { get; set; }
		
		public CreateModel(AppDbContext context)
		{
			_context = context;
		}
		
		public void OnGet() {
			
		}
		
		public IActionResult OnPost() {
			
			if(!ModelState.IsValid)
				return Page();
			
			Book.SellPrice = CalculateSellPrice(Book);
			
			_context.Books.Add(Book);
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