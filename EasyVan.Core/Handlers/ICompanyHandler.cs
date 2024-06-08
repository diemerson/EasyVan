using EasyVan.Core.Models;
using EasyVan.Core.Requests.Companies;
using EasyVan.Core.Responses;

namespace EasyVan.Core.Handlers;

public interface ICompanyHandler
{
	Task<Response<Company?>> CreateAsync(CreateCompanyRequest request);
}
