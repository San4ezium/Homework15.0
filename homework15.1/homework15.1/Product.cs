using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework15._1;
class Product
{
    protected double BasePrice;

    public Product(double basePrice)
    {
        BasePrice = basePrice;
    }

    public virtual double Price
    {
        get { return BasePrice; }
    }

    public virtual string Info()
    {
        return "Product: " + GetType().Name + ", Price: " + Price;
    }
}
