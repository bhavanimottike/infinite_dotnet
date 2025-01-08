using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment2
{
    class products
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int price { get; set; }
    }
     class programe
    {
        static void Main()
        {
            List<products> productdetails = new List<products>();
             for(int i =1;i <11; i++)
            {
                Console.WriteLine("enter product {0} details", i);
                Console.WriteLine("product id");
                int product_id = int.Parse(Console.ReadLine());
                Console.WriteLine("product name");
                string product_name = (Console.ReadLine());
                Console.WriteLine("product price");
                int price = int.Parse(Console.ReadLine());
                productdetails.Add(new products { product_id = product_id, product_name = product_name, price = price });



            }
            productdetails = productdetails.OrderBy(p => p.price).ToList();
            Console.WriteLine("sorted products");
            foreach( var product in productdetails)
            {
                Console.WriteLine($"{product.product_id},product name{product.product_name},price {product.price}");
                
            }
            Console.Read();
        }
    }
}
