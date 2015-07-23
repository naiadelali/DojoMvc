using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoMvc.Dao;
using DojoMvc.Repository;

namespace DojoMvc.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private IProductRepository Service;

        public ProductBusiness(IProductRepository Service)
        {
            this.Service = Service;
        }

        //insert
        public void Insert(ProductDao p)
        {
            this.Service.Insert(p);
        }

        //update
        public void Update(ProductDao p)
        {
            this.Service.Update(p);
        }

        //delete
        public void Delete(ProductDao p)
        {
            this.Service.Delete(p);
        }

        //select by id
        public ProductDao SelectById(int id)
        {
            return this.Service.SelectById(id);
        }

        //select all
        public List<ProductDao> SelectAll()
        {
            return this.Service.SelectAll();
        }
    }
}
