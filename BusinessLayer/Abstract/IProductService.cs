using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAll();
        Product GetId(int id);
        Product GetById(int productId);
        List<ProductDetailDto> GetProductDetails();
        List<Product> GetListWithCategory();

    }
}
