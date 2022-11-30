using EntitiesLayer.Concrete;

namespace PresentationUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
