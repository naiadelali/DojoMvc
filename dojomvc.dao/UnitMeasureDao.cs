using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoMvc.Dao
{
    [Table("UnitMeasure")]
    public class UnitMeasureDao
    {
        [Key]
        public int id { get; set; }

        public string Abbreviation { get; set; }

        public string Description { get; set; }
    }
}
