using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login2.Models
{
    public class Cliente
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public string Relatorio { get; set; }
    }
}
