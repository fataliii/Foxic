namespace Foxic.Core.Entities;

public class Size : BaseEntity
{
    public string Name { get; set; }
	public ICollection<OrderItem> Products { get; set; }

}
