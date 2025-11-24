namespace LAB_krull.models;

/// <summary>
/// 
/// </summary>
public class City
{
	public int Id { get; set; }
	public string Name { get; set; }
	public Country Country { get; set; }
	public List<Property> Properties { get; set; } = new List<Property>();   
}