using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoMvc.Dao;

namespace DojoMvc.Repository
{
    public class ProductRepository : IProductRepository
    {
       
        //insert
        public void Insert(ProductDao p)
        {
            using (DojoContext context = new DojoContext())
            {
                context.Produto.Add(p);
                context.SaveChanges();
            }
        }

        //update
        public void Update(ProductDao p)
        {
            using (DojoContext context = new DojoContext())
            {
                context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //delete
        public void Delete(ProductDao p)
        {
            using (DojoContext context = new DojoContext())
            {
                context.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //find by id
        public ProductDao SelectById(int id)
        {
            using (DojoContext context = new DojoContext())
            {
                return context.Produto.Find(id);
                
            }
        }

        //select all
        public List<ProductDao> SelectAll()
        {
            using (DojoContext context = new DojoContext())
            {
                return context.Produto.ToList();
            }
        }
    }
}
