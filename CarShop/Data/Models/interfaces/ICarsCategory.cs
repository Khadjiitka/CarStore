namespace CarShop.Data.Models.interfaces
{
     public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
