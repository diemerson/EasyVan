using EasyVan.Core.Models;
using EasyVan.Core.Requests.Vans;
using EasyVan.Core.Responses;

namespace EasyVan.Core.Handlers;

public interface IVanHandler
{
	Task<Response<Van?>> CreateAsync(CreateVanRequest request);
}
