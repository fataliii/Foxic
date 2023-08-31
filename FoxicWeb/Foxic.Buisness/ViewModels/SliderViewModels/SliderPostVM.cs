using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Foxic.Business.ViewModels.SliderViewModels;

public class SliderPostVM
{
	[Required, MaxLength(30), MinLength(5)]
	public string Title { get; set; } = null!;
	[Required, MaxLength(80)]
	public string Desc { get; set; } = null!;
	[Required]
	public IFormFile ImageUrl { get; set; }= null!;
}
