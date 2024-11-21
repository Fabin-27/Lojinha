using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provaofc_2
{
    internal class Venda
    {
        public int Id { get; set; }
        public int ValorDaVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public string FormaPagamento { get; set; }

        public Venda() { }
    }
}
