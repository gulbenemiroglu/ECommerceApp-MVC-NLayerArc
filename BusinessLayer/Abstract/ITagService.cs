using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITagService
    {
        void Add(Tag tag);
        void Delete(Tag tag);
        void Update(Tag tag);
        List<Tag> GetAll();
        Tag GetId(int tagId);
    }
}
