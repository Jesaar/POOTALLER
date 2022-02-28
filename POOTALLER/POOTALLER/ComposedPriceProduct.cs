using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTALLER
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal AcumProduct = 0;
            decimal Disc;

            foreach (Product products in Products)
            {
                AcumProduct += products.ValueToPay();
            }
            Disc = AcumProduct * (decimal)Discount;

            return AcumProduct - Disc;
        }
        public override string ToString()
        {
            string ass = string.Empty;

            foreach (Product products in Products)
            {
                ass += products.Description + ", ";
            }

            return $"{base.ToString()}" +
                $"\n\tProducts....:{ass}" +
                $"\n\tDiscount....:{$"{Discount:P2}",15}" +
                $"\n\tValue.......:{$"{ValueToPay():C2}",15}";
        }
    }
}
