using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LAB_krull.Pages;

public class statesModel : PageModel
{
	public string StateName { get; set; }
	public int? Rating { get; set; }
	public int? Population { get; set; }

	public void OnGet(string stateName, int? rating, int? population)
	{
		StateName = stateName;
		Rating = rating;
		Population = population;
	}
}