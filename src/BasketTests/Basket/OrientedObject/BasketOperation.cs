using System.Collections.Generic;

namespace Basket.OrientedObject
{
    public class BasketOperation
    {
        private readonly Infrastructure.BasketService _basketService;

        public BasketOperation(Infrastructure.BasketService basketService)
        {

            _basketService = basketService;
            
        }

        public int CalculateAmount(List<BasketLineArticle> basketLineArticles)
        {
            var basket = _basketService.GetBasket(basketLineArticles);
            return basket.Calulate();
        }
    }
}