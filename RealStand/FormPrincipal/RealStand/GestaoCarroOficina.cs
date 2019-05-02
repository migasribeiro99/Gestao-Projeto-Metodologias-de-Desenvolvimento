using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStand
{
    public partial class GestaoCarroOficina : Form
    {
        BaseDadosRealStandContainer meuStand;
        public GestaoCarroOficina()
        {
            InitializeComponent();
        }
        private void CarregarDadosCliente()
        {
            listBoxClientes.DataSource = meuStand.Cliente.ToList<Cliente>();
        }
        private void CarregarDadosCarros()
        {
            listBoxCarroOficina.DataSource = meuStand.Carro.ToList<Carro>();

        }
        private void CarregarDadosServico()
        {
            listBoxServico.DataSource = meuStand.Servico.ToList<Servico>();
        }

        private void GestaoCarroOficina_Load(object sender, EventArgs e)
        {
            meuStand = new BaseDadosRealStandContainer();
            CarregarDadosCliente();
        }

        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            CarroOficina novoCarro = new CarroOficina(textBoxNumeroChassis.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxCombustivel.Text, textBoxMatricula.Text, textBoxKlms.Text);

            clienteSelecionado.CarroOficina.Add(novoCarro);

            meuStand.Carro.Add(novoCarro);
            meuStand.SaveChanges();
            listBoxCarroOficina.DataSource = null;
            listBoxCarroOficina.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();

        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarregarDadosCarros();
            listBoxCarroOficina.DataSource = null;
            listBoxCarroOficina.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();
        }

        private void buttonEliminarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            Carro carroSelecionado = (Carro)listBoxCarroOficina.SelectedItem;

            meuStand.Carro.Remove(carroSelecionado);
            meuStand.SaveChanges();
            listBoxCarroOficina.DataSource = null;
            listBoxCarroOficina.DataSource = clienteSelecionado.CarroOficina.ToList<CarroOficina>();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarroOficina.SelectedItem;
            Servico novoServico = new Servico(comboBoxServico.Text, dateTimePickerServico.Value.Date.ToShortDateString());

            carroSelecionado.Servico.Add(novoServico);
            meuStand.Servico.Add(novoServico);
            meuStand.SaveChanges();

            listBoxServico.DataSource = null;
            listBoxServico.DataSource = carroSelecionado.Servico.ToList<Servico>();
        }

        private void listBoxCarroOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarroOficina carroSelecionado = (CarroOficina)listBoxCarroOficina.SelectedItem;
                CarregarDadosServico();
                listBoxServico.DataSource = null;
                listBoxServico.DataSource = carroSelecionado.Servico.ToList<Servico>();
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
