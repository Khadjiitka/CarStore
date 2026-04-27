using CarShop.Data.Models;
using CarShop.Data.Models.interfaces;

namespace CarShop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {  get
            {
                return new List<Category>
                {
                    new Category { id = 1, categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { id = 2, categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        
        }
    }
}
