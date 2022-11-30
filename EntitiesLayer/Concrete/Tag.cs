using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Tag : IEntity
    {
        [Key]
        public int TagId { get; set; }
        public string TagName { get; set; }
        public ICollection<Product> Products { get; set; } //MANY TO MANY
    }
}
