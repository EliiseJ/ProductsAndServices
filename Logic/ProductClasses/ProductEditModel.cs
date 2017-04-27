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

        }

        public void Update(ProductInstance product)
        {
            
        }
    }
}
