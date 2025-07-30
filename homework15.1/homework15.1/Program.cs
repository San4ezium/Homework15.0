// See https://aka.ms/new-console-template for more information
using homework15._1;
using homework15._1.Vegetables;

class Program
{
    static void Main()
    {
        var products = new List<Product>()
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2),
        };

        VegetableShop shop = new VegetableShop();
        shop.AddProducts(products);
        shop.PrintProductsInfo();
    }
}
