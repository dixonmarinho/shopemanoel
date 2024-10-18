using shop.manoel.shared.Models.Request;

namespace shop.manoel.shared.Interfaces
{
    public interface IServiceAuth
    {
        string Login(UserRequest sender);

    }
}
