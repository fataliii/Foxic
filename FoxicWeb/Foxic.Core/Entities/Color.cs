namespace Foxic.Core.Entities;

public class Color : BaseEntity
{
	public ICollection<Product> Products { get; set; }
	public string Image { get; set; }
	public string Name { get; set; }
}
