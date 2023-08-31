namespace Foxic.Core.Entities;

public class ProductDetails : BaseEntity
{
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public bool Cotton { get; set; }
    public bool Polyester { get; set; }
    public bool Clean { get; set; }
    public bool NonChlorine { get; set; }
    public bool Tax { get; set; }
}
