using Microsoft.AspNetCore.Mvc;
using OrdersWebApp.Data;

namespace OrdersWebApp.Components;

public class OrderListViewComponent : ViewComponent
{
    private readonly IOrderRepo _repo;

    public OrderListViewComponent(IOrderRepo repo)
    {
        _repo = repo;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var orders = await _repo.GetAllOrdersAsync();

        var viewResult = View(orders);

        return viewResult;
    }
}
