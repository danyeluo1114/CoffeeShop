using System.Collections.Generic;

namespace CoffeeShop.DataAccess.Model
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Cleveland", BeanInStockInKg = 107 };
            yield return new CoffeeShop { Location = "Chicago", BeanInStockInKg = 23 };
            yield return new CoffeeShop { Location = "LA", BeanInStockInKg = 56 };
        }

    }
}
