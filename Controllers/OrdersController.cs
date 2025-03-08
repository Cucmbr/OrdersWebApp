using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdersWebApp.Data;
using OrdersWebApp.Models;

namespace OrdersWebApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepo _repository;

        public OrdersController(IOrderRepo repo)
        {
            _repository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetOrder(Guid id)
        {
            var order = await _repository.GetOrderByIdAsync(id);

            return PartialView("GetOrder", order);
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            if (!ModelState.IsValid)
                return View();

            await _repository.CreateOrderAsync(order);
            await _repository.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            var order = await _repository.GetOrderByIdAsync(id);
            
            if (order == null)
                return RedirectToAction("Index");

            _repository.DeleteOrder(order);
            await _repository.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
