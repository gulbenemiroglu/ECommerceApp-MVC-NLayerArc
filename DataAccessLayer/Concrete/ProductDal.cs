using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ProductDal : Repository<Product>, IProductDal
    {
        public List<Product> GetListWithCategory()
        {
            using (Context context = new Context())
            {
                return context.Products.Include(p => p.Category).ToList();
            }
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            using (Context context = new Context())
            {
                var result = from c in context.Products
                             join x in context.Categories
                          on c.ProductId equals x.CategoryId
                             join b in context.Tags
                           on c.TagId equals b.TagId
                             select new ProductDetailDto { ProductName = c.ProductName, CategoryName = c.Category.CategoryName, TagName = b.TagName, Quantity = c.Quantity, UnitPrice = c.UnitPrice };

                return result.ToList();

            }
        }

    }
}
