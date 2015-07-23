using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoMvc.Dao;

namespace DojoMvc.Business
{
    public interface IProductBusiness
    {
        //insert
        void Insert(ProductDao p);

        //update
        void Update(ProductDao p);

        //delete
        void Delete(ProductDao p);

        //select by id
        ProductDao SelectById(int id);

        //select all
        List<ProductDao> SelectAll();
    }
}
