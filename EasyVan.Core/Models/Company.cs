namespace EasyVan.Core.Models;

public class Company
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Contact { get; set; } = string.Empty;
	public List<Van> Vans { get; set; } = null!;
	public List<Trip> Trips { get; set; } = null!;
}
