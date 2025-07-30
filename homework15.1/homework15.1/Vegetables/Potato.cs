using homework15._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework15._1.Vegetables;

class Potato : Product
{
    private double Count;

    public Potato(double basePrice, double count) : base(basePrice)
    {
        Count = count;
    }

    public override double Price
    {
        get { return BasePrice * Count; }
    }

    public override string Info()
    {
        return "Product: Potato, Price: " + BasePrice + ", Count: " + Count + ", Total price: " + Price;
    }
}


