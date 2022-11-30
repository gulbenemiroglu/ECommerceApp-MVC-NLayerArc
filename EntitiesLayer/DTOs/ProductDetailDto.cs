using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.DTOs
{
    public class ProductDetailDto:IProductDetailDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string TagName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
