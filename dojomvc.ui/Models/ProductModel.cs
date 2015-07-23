using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DojoMvc.Dao;
using DojoMvc.Business;

namespace DojoMvc.Ui.Models
{
    public class ProductModel
    {
        public string Filter { get; set; }
        public List<ProductDao> ListaDeProduto { get; set; }
        public List<string> ListOfFilters { get; set; }
    }
}