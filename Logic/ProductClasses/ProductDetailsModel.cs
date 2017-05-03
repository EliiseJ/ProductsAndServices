using Open.Archetypes.ProductClasses;
using System.Xml;

namespace Open.Logic.ProductClasses
{
    public class ProductDetailsModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public ProductDetailsModel() { }
        public ProductDetailsModel(ProductInstance product)
        {
            Name = product.Name;
            Genre = (product.Type == null) ? product.TypeId : product.Type.Name;
        }
    }
}
