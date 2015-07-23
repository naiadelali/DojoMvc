using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DojoMvc.Ui.Models
{
    public class ProductCadastroModel
    {

        public int id { get; set; }

        [Required(ErrorMessage="O nome é obrigatório")]    
        public string Name { get; set; }

        [RegularExpression("^[0-9]*$",ErrorMessage="Somente números")]
        public double? Price { get; set; }
    }
}