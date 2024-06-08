using System.ComponentModel.DataAnnotations;

namespace EasyVan.Core.Requests.Trips;

public class CreateTripRequest : Request
{
	[Required(ErrorMessage = "Local de partida deve ser informado")]
	[MaxLength(150, ErrorMessage = "Local de partida deve conter no máximo 150 caracteres")]
	public string StartingPoint { get; set; } = string.Empty;

	[Required(ErrorMessage = "Destino deve ser informado")]
	[MaxLength(150, ErrorMessage = "Destino deve conter no máximo 150 caracteres")]
	public string Destination { get; set; } = string.Empty;

	[Required(ErrorMessage = "O valor da tarifa deve ser informado")]
	public int FareAmount { get; set; }
}
