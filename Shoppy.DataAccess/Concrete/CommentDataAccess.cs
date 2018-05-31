using Shoppy.Data;
using Shoppy.DataAccess.Abstraction;
using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Concrete
{
    public class CommentDataAccess : ICommentRepository
    {
        private DbContext Context;
        private DbSet<Comment> table;

        public CommentDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<Comment>();
        }
        public bool AddItem(Comment entity)//İtem Ekleme
        {
            table.Add(entity);
            try
            {

                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Comment entity)//Silme
        {
            table.Remove(entity);

            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Comment> GetList()//Listeleme
        {
            return table.ToList();
        }

        public List<Comment> GetSpecificComments(int productID)
        {
            List<Comment> Comments = GetList();
            foreach (var comment in Comments.ToList())
            {
                if (comment.ProductID != productID)
                {
                    Comments.Remove(comment);
                }
            }
            return Comments;
        }

        public bool Update(Comment entity)//Güncelleme
        {
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
