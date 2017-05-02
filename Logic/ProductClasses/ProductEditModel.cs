using Open.Archetypes.ProductClasses;
using System.Xml;

namespace Open.Logic.ProductClasses
{
    public class ProductEditModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Id { get; set; }

        public ProductEditModel() { }
        public ProductEditModel(ProductInstance product)
        {
            Id = product.UniqueId;
            Name = product.Name;
            Genre = (product.Type == null) ? product.TypeId : product.Type.Name;
        }

        public void Update(ProductInstance p)
        {
            var a = p.Product as Products;
            p.Name = Name;
            p.TypeId = Genre;
        }
    }
}
