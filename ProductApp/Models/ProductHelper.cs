namespace ProductApp.Models
{
    internal class ProductHelper
    {
        public static Product MostExpensive(List<Product> products)
        {
            Product mostExpensive = products[0];

            for (int i = 1; i < products.Count; i++)
            {
                if (mostExpensive.Price < products[i].Price)
                {
                    mostExpensive = products[i];
                }
            }

            return mostExpensive;
        }

        public static Product MostExpensive(List<Product> products, double maxPrice)
        {
            Product mostExpensive = null;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price <= maxPrice)
                {
                    if (mostExpensive == null || mostExpensive.Price < products[i].Price)
                        mostExpensive = products[i];
                }
            }

            return mostExpensive;
        }
    }
}
