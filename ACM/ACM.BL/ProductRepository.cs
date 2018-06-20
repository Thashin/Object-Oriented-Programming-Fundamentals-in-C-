using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();

            if(productId==2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 19.6M;
            }
            return product;
        }
    }
}
