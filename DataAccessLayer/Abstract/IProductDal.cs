using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal: IRepository<Product>
    {
        List<Product> GetListWithCategory();
        List<ProductDetailDto> GetProductDetails();

    }
}
