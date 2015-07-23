using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoMvc.Dao
{
    [Table("Product")]
    public class ProductDao
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public double price { get; set; }
    }
}
