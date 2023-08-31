namespace Foxic.Core.Entities;

public class ProductColor : BaseEntity
{
	public Color Color { get; set; }
	public Product Product { get; set; }
    public int ColorId { get; set; }
    public int ProductId { get; set; }

}
