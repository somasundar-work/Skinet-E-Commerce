using System.Linq.Expressions;
using Skinet.Entities.Product;

namespace Skinet.Application.Specifications;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(string? brand, string? category, string? sort)
        : base(p =>
            (string.IsNullOrEmpty(brand) || p.Brand == brand)
            && (string.IsNullOrEmpty(category) || p.Category == category)
        )
    {
        switch (sort)
        {
            case "priceAsc":
                AddOrderBy(p => p.Price);
                break;
            case "priceDesc":
                AddOrderByDescending(p => p.Price);
                break;
            default:
                AddOrderBy(p => p.Name);
                break;
        }
    }
}
