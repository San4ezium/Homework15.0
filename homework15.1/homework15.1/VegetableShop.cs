using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework15._1;

class VegetableShop
{
    private List<Product> products = new List<Product>();

    public void AddProducts(List<Product> newProducts)
    {
        products.AddRange(newProducts);
    }

    public void PrintProductsInfo()
    {
        double total = 0;
        foreach (Product product in products)
        {
            System.Console.WriteLine(product.Info());
            total += product.Price;
        }
        System.Console.WriteLine("Total products price: " + total);
    }
}
