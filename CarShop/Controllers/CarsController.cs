using CarShop.Data.Models.interfaces;
using CarShop.ViewModels;
using System.Web.Mvc;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        //конструктор для впровадження залежностей, який приймає інтерфейси IAllCars та ICarsCategory і присвоює їх приватним полям _allCars та _allCategories відповідно
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        // повертає HTML сторінку з автомобілями
        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
