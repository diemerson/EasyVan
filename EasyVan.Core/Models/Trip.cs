namespace EasyVan.Core.Models;

public class Trip
{
	public Guid Id { get; set; }
	public string StartingPoint { get; set; } = string.Empty;
	public string Destination { get; set; } = string.Empty;
	public decimal FareAmount { get; set; }
}
