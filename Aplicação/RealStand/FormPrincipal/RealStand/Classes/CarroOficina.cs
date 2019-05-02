using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class CarroOficina
    {
        private List<Carro>_carro;
        public Decimal TotalCarroOficina
        {
            get
            {
                Decimal totalCarro = 0;
                foreach (Carro item in _carro)
                {
                    totalCarro += item.TotalServico;
                }
                return totalCarro;
            }
        }

        public CarroOficina(string nChassis, string marca, string modelo, string combustivel, string matricula, string klm )
        {
            this.NumeroChassis = nChassis;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
            this.Matricula = matricula;
            this.Kms = klm;
            _carro = new List<Carro>();
        }

        public override string ToString()
        {
            return Marca;
        }

    }
}
