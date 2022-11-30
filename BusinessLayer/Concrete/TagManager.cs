using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TagManager:ITagService
    {
        ITagDal _tagDal;
        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }
        public void Add(Tag tag)
        {
            _tagDal.Add(tag);
        }

        public void Delete(Tag tag)
        {
            _tagDal.Delete(tag);
        }

        public List<Tag> GetAll()
        {
            return _tagDal.GetAll();
        }

        public Tag GetId(int tagId)
        {
            return _tagDal.GetId(tagId);
        }

        public void Update(Tag tag)
        {
            _tagDal.Update(tag);
        }
    }
}
