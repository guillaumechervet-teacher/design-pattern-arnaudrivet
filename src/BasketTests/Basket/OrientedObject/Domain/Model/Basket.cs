using System.Collections.Generic;

namespace Basket.OrientedObject.Domain.Model
{
    public class Basket
    {
        private readonly List<BasketLine> _basketLines;

        public Basket(List<BasketLine> basketLines)
        {
            _basketLines = basketLines;
        }

        public int Calulate()
        {
            var total = 0;
            foreach (var basketLine in _basketLines)
            {
                total += basketLine.Calculate();
            }

            return total;
        }
    }
}