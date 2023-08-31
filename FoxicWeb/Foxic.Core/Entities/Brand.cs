namespace Foxic.Core.Entities;

public class Brand: BaseEntity
{
    public ICollection<Product> Products { get; set; }
    public string BrandName { get; set; }
    public string Image { get; set;}
}
