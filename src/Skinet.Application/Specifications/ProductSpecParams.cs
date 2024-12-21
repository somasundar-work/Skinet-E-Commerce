namespace Skinet.Application.Specifications;

public class ProductSpecParams
{
    public const int MaxPageSize = 50;
    public int PageIndex { get; set; } = 1;

    private int _pageSize = 6;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
    }

    private List<string> _brands = [];
    public List<string> Brands
    {
        get => _brands;
        set =>
            _brands = value
                .SelectMany(x => x.Split(",", StringSplitOptions.RemoveEmptyEntries))
                .ToList();
    }

    private List<string> _categories = [];
    public List<string> Categories
    {
        get => _categories;
        set =>
            _categories = value
                .SelectMany(x => x.Split(",", StringSplitOptions.RemoveEmptyEntries))
                .ToList();
    }

    public string? Sort { get; set; }
}
