using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTALLER
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();

        public Invoice() { }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal value = 0;
            foreach (Product product in _products)
            {
                value += product.ValueToPay();
            }
            return value;
        }
        public override string ToString()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }
            return $"TOTAL:{$"{ValueToPay():C2}",30}";

        }
    }
}
