namespace Foxic.Core.Entities;

public class ProductSize : BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public int SizeId { get; set; }
	public Size Size { get; set; }



}
