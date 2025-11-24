using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LAB_krull.Pages.CityManager;

public class CreateModel : PageModel
{
	[BindProperty]
	public string CityName { get; set; }
	public string Message { get; set; }
	public void OnGet()
	{
	}
}