using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Servico
    {

        public Decimal TotalServico
        {
            get
            {
                Decimal totalServico = 0;
                //foreach (Parcela item in this.Parcela)
                //{
                //    totalServico += item.valor;
                //}
                return totalServico;
            }
        }

        public Servico(string servico, string dataEntrada)
        {
            this.Tipo = servico;
            this.DataEntrada = dataEntrada;
            this.Parcela = new HashSet<Parcela>();
        }

        public override string ToString()
        {
            return Tipo + " (" + DataEntrada + ")" + " " + TotalServico + "€";
        }
    }
}
