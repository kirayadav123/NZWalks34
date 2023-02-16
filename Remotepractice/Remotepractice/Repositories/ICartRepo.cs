using Remotepractice.Models.Domain;

namespace Remotepractice.Repositories
{
    public interface ICartRepo
    {
        Task<IEnumerable<CartModel>> GetCart();
        Task<CartModel> GetCartById(int id);
        Task<CartModel> AddCart(CartModel cartModel);
        Task<CartModel> UpdateCart(CartModel cartModel);
        void DeleteCart(int id);

    }
}
