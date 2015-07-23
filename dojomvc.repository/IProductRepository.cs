using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoMvc.Dao;

namespace DojoMvc.Repository
{
    public interface IProductRepository
    {
        //insert
        void Insert(ProductDao p);

        //update
        void Update(ProductDao p);

        //delete
        void Delete(ProductDao p);

        //find by id
        ProductDao SelectById(int id);

        //select all
        List<ProductDao> SelectAll();
    }
}
