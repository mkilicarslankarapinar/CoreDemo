using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
       

        public void Delete(Blog t)
        {
            using var c = new BlogContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            using var c = new BlogContext();
            return c.Blogs.ToList();
        }

        public void Insert(Blog t)
        {
            using var c = new BlogContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Blog t)
        {
            using var c = new BlogContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
