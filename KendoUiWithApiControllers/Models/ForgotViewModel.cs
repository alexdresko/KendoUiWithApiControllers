using System.ComponentModel.DataAnnotations;

namespace KendoUiWithApiControllers.Models
{
	public class ForgotViewModel
	{
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}