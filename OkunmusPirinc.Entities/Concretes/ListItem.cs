using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.Entities.Concretes
{
    public class ListItem
    {
        public List<Product> Products;
        public List<ProductCategory> Categories;
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public int ItemPerPage { get; set; } = 12;
        public ListItem()
        {

        }
        public ListItem(int itemsPerPage)
        {
            this.ItemPerPage = itemsPerPage;
        }
        public ListItem(List<Product> products, List<ProductCategory> categories)
        {
            this.Products = products;
            this.Categories = categories;
        }
        public ListItem(List<Product> products, List<ProductCategory> categories,int itemsPerPage)
        {
            this.Products = products;
            this.Categories = categories;
            this.ItemPerPage = itemsPerPage;
        }
    }
}
