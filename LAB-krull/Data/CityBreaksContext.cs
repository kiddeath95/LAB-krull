using Microsoft.EntityFrameworkCore;

namespace LAB_krull.Data;

/// <summary>
/// 
/// </summary>
public class CityBreaksContext : DbContext
{
	public CityBreaksContext(DbContextOptions options) : base(options)
	{

	}
	/*  public DbSet<City> Cities { get; set; }
	  public DbSet<Country> Countries { get; set; }
	  public DbSet<Property> Properties { get; set; }*/
}