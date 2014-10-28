using System.ComponentModel.DataAnnotations;

namespace KendoUiWithApiControllers.Models
{
	public class ExternalLoginConfirmationViewModel
	{
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}