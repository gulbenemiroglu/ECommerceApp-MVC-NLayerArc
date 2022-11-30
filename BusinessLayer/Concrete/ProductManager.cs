using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
        public Product GetById(int productId)
        {
            return _productDal.GetById(x => x.ProductId == productId);

        }
        public Product GetId(int id)
        {
            return _productDal.GetId(id);
        }

        public List<Product> GetListWithCategory()
        {
            return _productDal.GetListWithCategory();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
          

            return _productDal.GetProductDetails();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
