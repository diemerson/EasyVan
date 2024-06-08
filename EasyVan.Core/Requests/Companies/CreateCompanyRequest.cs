using System.ComponentModel.DataAnnotations;

namespace EasyVan.Core.Requests.Companies;

public class CreateCompanyRequest : Request
{
    [Required(ErrorMessage = "Nome da empresa deve ser preenchido")]
    [MaxLength(150, ErrorMessage = "Nome da empresa deve conter no máximo 150 caracteres")]
    public string Name { get; set; } = string.Empty;

	[Required(ErrorMessage = "Contato deve ser preenchido")]
	[MaxLength(50, ErrorMessage = "Contato deve conter no máximo 50 caracteres")]
	public string Contact { get; set; } = string.Empty;
}
