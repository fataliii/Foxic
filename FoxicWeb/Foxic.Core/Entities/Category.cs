namespace Foxic.Core.Entities;

public class Category : BaseEntity 
{
	public ICollection<Product> Products { get; set; }
	public string CategoryName { get; set; }
}
