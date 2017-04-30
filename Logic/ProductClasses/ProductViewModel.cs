using Open.Archetypes.BaseClasses;
using Open.Archetypes.ProductClasses;

namespace Open.Logic.ProductClasses
{
    public class ProductViewModel
    {
        public ProductViewModel() { }
        public ProductViewModel(ProductInstance p)
        {
            Id = p.UniqueId;
            Name = p.Name;
            Genre = (p.Type == null) ? p.TypeId : p.Type.Name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
