using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Parcela
    {
        public Decimal valor;

        public Parcela(string descricaoPecas, Decimal valor)
        {
            this.Descricao = descricaoPecas;
            this.valor = valor;
        }

        public override string ToString()
        {
            return Descricao + " (" + valor.ToString() + " €)";
        }
    }
}
