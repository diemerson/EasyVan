using System.ComponentModel.DataAnnotations;

namespace EasyVan.Core.Requests.Vans;

public class CreateVanRequest : Request
{
	[Required(ErrorMessage = "A quantidade de acentos deve ser informada")]
	public int Capacity { get; set; }
}
