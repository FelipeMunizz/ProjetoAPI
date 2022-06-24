using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entidades
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
