using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provaofc_2
{
    internal class Produto
    {

        private int Id { get; set; }
        private string Nome { get; set; }
        private double Preço { get; set; }
        private int Quantidade_Estoque {get; set;}
        private string Codigo_de_Barras { get; set; }

        public Produto() { }
    }
}
