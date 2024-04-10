using Blazored.LocalStorage;
using Blazored.Toast.Services;
using ShopEasily.Client.Services.ProductService;
using ShopEasily.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(
            ILocalStorageService localStorage,
            IToastService toastService,
            IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        // Adds an item to the shopping cart.
        public async Task AddToCart(CartItem item)
        {
            // Logic to add the item to the cart stored in local storage.
            // Shows a success toast indicating the item has been added to the cart.
            // Triggers the OnChange event to notify subscribers that the cart has changed.   

            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart
                .Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }

            await _localStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange.Invoke();
        }

        // Retrieves the items from the shopping cart.
        public async Task<List<CartItem>> GetCartItems()
        {
            // Retrieves the cart items from local storage.
            // Returns the list of cart items.

            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>();
            }
            return cart;
        }

        // Deletes an item from the shopping cart.
        public async Task DeleteItem(CartItem item)
        {
            // Logic to delete the specified item from the cart stored in local storage.
            // Triggers the OnChange event to notify subscribers that the cart has changed.

            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        // Empties the shopping cart.
        public async Task EmptyCart()
        {
            // Removes all items from the cart stored in local storage.
            // Triggers the OnChange event to notify subscribers that the cart has changed.

            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }
    }
}

