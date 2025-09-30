using project.Model;
using System.ComponentModel.DataAnnotations;

namespace project.Enums {
	
	public enum ELanguage {
    [Display(Name = "English")]
    EN = 0,
    [Display(Name = "فارسی")]
    FA = 1,
    [Display(Name = "العربية")]
    AR = 2,
    [Display(Name = "Français")]
    FR = 3
}
}
