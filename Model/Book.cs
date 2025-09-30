using System.ComponentModel.DataAnnotations;
using project.Enums;

namespace project.Model
{

	public class Book
	{

		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage="Title characters must be 3-400")]
		[StringLength(400, MinimumLength = 3)]
		public string Title { get; set; }
		[Required]
		[StringLength(150, MinimumLength = 3,ErrorMessage="Title characters must be 3-150")]
		public string AuthorName { get; set; }
		[Required(ErrorMessage="defining language is neccesary!")]
		public ELanguage Language { get; set; }
		[Required(ErrorMessage="define the price is neccesary!")]
		public decimal Price { get; set; }
		[Range(0, 100)]
		public int DiscountPercent { get; set; } = 0;
		public decimal SellPrice { get; set; }
	}

}