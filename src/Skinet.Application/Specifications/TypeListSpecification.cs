using Skinet.Entities.Product;

namespace Skinet.Application.Specifications;

public class TypeListSpecification : BaseSpecification<Product, string>
{
    public TypeListSpecification()
    {
        AddSelect(x => x.Name);
        ApplyDistinct();
    }
}
