using shop.manoel.shared.Models.Request;
using shop.manoel.shared.Models.Response;

namespace shop.manoel.shared.Interfaces
{
    public interface IServiceOrder
    {
        Task<List<OrderResponse>> CalcOrderBoxAsync(OrderRequest orders);
    }
}
