using AhsanSports.Data;
using AhsanSports.Models.Domain;
using AhsanSports.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AhsanSports.Controllers
{
    public class AdminAddItemController : Controller
    {
        private readonly ItemsDbContext itemsDbContext;

        public AdminAddItemController(ItemsDbContext itemsDbContext)
        {
            this.itemsDbContext = itemsDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddItemRequest request)
        {
            var item = new Items
            {
                Name = request.Name,
                Price = request.Price,
                IsAvailable = request.IsAvailable
            };

            itemsDbContext.Add(item);
            itemsDbContext.SaveChanges();

            return View("Add");
        }
    }
}
