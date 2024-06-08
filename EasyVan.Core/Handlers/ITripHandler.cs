using EasyVan.Core.Models;
using EasyVan.Core.Requests.Trips;
using EasyVan.Core.Responses;

namespace EasyVan.Core.Handlers;

public interface ITripHandler
{
	Task<Response<Trip?>> CreateAsync(CreateTripRequest request);
}
