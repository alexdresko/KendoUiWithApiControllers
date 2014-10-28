using System.ComponentModel.DataAnnotations;

namespace KendoUiWithApiControllers.Models
{
	public class AddPhoneNumberViewModel
	{
		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string Number { get; set; }
	}
}