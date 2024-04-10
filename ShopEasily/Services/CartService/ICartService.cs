using ShopEasily.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.CartService
{
    // This interface defines the contract for a service responsible for managing the shopping cart.
    public interface ICartService
    {
        // Event triggered when the cart changes.
        event Action OnChange;

        // Adds an item to the shopping cart.
        Task AddToCart(CartItem item);

        // Retrieves the items from the shopping cart.
        Task<List<CartItem>> GetCartItems();

        // Deletes an item from the shopping cart.
        Task DeleteItem(CartItem item);

        // Empties the shopping cart.
        Task EmptyCart();
    }
}
