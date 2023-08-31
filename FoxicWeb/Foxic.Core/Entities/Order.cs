namespace Foxic.Core.Entities;

public class Order : BaseEntity
{
	public ICollection<OrderItem> Products { get; set; }
	public int TotalPrice { get; set; }
    public DateTime CreatedTime { get; set; }
    public string Description { get; set;}
}
