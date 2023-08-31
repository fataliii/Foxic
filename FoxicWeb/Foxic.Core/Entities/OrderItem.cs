namespace Foxic.Core.Entities;

public class OrderItem : BaseEntity
{
    public double Price { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public int Count { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }
	public Product Products { get; set; }
	public Order Orders { get; set; }

}
