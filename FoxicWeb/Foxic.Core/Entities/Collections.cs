namespace Foxic.Core.Entities;

public class Collections: BaseEntity
{
	public ICollection<Product> Products { get; set; }
	public string CollectionName { get; set; }
	public string Image { get; set; }

}
