using Microsoft.AspNetCore.Mvc.RazorPages;
using LAB_krull.models;
using Microsoft.AspNetCore.Mvc;

namespace LAB_krull.Pages;

public class CityModel : PageModel
{
	[BindProperty]
	public List<int>SelectedCities { get; set; } = new List<int>();
	public List<City> Cities = new List<City> { 
		new City {Id=1, Name= "London"},
		new City {Id=2, Name= "Paris"},
		new City {Id=3, Name= "New York"},
		new City {Id=4, Name= "Rome"},
		new City {Id=5, Name= "Dublin"}
	};
	public void OnGet()
	{
	}
}