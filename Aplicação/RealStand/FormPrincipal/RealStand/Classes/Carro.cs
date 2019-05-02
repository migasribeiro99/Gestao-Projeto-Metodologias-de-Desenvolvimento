using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Carro
    {
        private List<Servico> _servico;
        public Decimal TotalServico
        {
            get
            {
                Decimal totalCarro = 0;
                foreach (Servico item in _servico)
                {
                    totalCarro += item.TotalServico;
                }
                return totalCarro;
            }
        }

        public Carro()
        {
            _servico = new List<Servico>();
        }

    

    }
}
