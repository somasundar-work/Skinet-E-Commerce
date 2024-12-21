using System.Linq.Expressions;
using Skinet.Entities.Product;

namespace Skinet.Application.Specifications;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(ProductSpecParams specParams)
        : base(p =>
            (specParams.Brands.Count == 0 || specParams.Brands.Contains(p.Brand))
            && (specParams.Categories.Count == 0 || specParams.Categories.Contains(p.Category))
        )
    {
        ApplyPaging(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);
        switch (specParams.Sort)
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
