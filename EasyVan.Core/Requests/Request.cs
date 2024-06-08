namespace EasyVan.Core.Requests;

//não pode ser instanciada, apenas herdada e extendida
public abstract class Request
{
	public Guid UserId { get; set; }
}
