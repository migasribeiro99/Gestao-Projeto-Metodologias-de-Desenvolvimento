using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Cliente
    {

        public Decimal Total
        {
            get
            {
                Decimal TotalCliente = 0;
                foreach (CarroOficina item in this.CarroOficina)
                {
                    TotalCliente = TotalCliente + item.TotalCarroOficina;
                }
                return TotalCliente;
            }
        }

        public Cliente(string nome, string nif, string morada, string contacto)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.Morada = morada;
            this.Contacto = contacto;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}