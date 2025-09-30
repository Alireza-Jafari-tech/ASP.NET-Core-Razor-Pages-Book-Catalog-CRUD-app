using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Model;
using project.Data;

namespace project.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
	public List<Book> Books { get; set; }

    public IndexModel(AppDbContext context)
		{
			_context = context;
		}

    public void OnGet()
    {
		Books = _context.Books.ToList();
    }
}
