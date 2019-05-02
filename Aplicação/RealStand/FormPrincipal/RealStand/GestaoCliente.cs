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
    public partial class GestaoCliente : Form
    {
        private BaseDadosRealStandContainer meuStand;

        public GestaoCliente()
        {
            InitializeComponent();
        }

        private void GestaoCliente_Load(object sender, EventArgs e)
        {
            meuStand = new BaseDadosRealStandContainer();
            CarregarDadosCliente();
        }

        private void CarregarDadosCliente()
        {
            listBoxNomeClientes.DataSource = meuStand.Cliente.ToList<Cliente>();
        }



        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            string morada = comboBoxMorada.Text;
            if(textBoxNomeCliente.Text.Length == 0 || textBoxNifCliente.Text.Length == 0 || comboBoxMorada.Text.Length == 0 || textBoxContacto.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos!!");
                return;
            }

            Cliente novoCliente = new Cliente(textBoxNomeCliente.Text, textBoxNifCliente.Text, morada, textBoxContacto.Text);

            textBoxNomeCliente.Text = "";
            textBoxNifCliente.Text = "";
            comboBoxMorada.Text = "";
            textBoxContacto.Text = "";

            meuStand.Cliente.Add(novoCliente);
            meuStand.SaveChanges();
            listBoxNomeClientes.DataSource = null;
            CarregarDadosCliente();
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxNomeClientes.SelectedItem;

            try
            {
                meuStand.Cliente.Remove(clienteSelecionado);
                meuStand.SaveChanges();
                listBoxNomeClientes.DataSource = null;
                CarregarDadosCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossivel Eliminar Cliente, tem um ou mais carros associados!!");
            }
        }

        private void buttonAtualizarCliente_Click(object sender, EventArgs e)
        {
            textBoxNomeAlterar.Enabled = true;
            textBoxNifAlterar.Enabled = true;
            textBoxContactoAlterar.Enabled = true;
            comboBoxMoradaAlterar.Enabled = true;
            buttonGuardarAlteracoes.Enabled = true;
            buttonCancelarAtua.Enabled = true;
            listBoxNomeClientes.Enabled = false;

            try
            {
                Cliente clienteSelecionado = (Cliente)listBoxNomeClientes.SelectedItem;
                if (clienteSelecionado.Nome != null || clienteSelecionado.NIF != null || clienteSelecionado.Morada != null || clienteSelecionado.Contacto != null)
                {
                    textBoxNomeAlterar.Text = clienteSelecionado.Nome;
                    textBoxNifAlterar.Text = clienteSelecionado.NIF;
                    comboBoxMoradaAlterar.Text = clienteSelecionado.Morada;
                    textBoxContactoAlterar.Text = clienteSelecionado.Contacto;
                }
                else
                    return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sem Cliente Selecionado");
            }
        }

        private void buttonCancelarAtua_Click(object sender, EventArgs e)
        {
            textBoxNomeAlterar.Text = "";
            textBoxNifAlterar.Text = "";
            textBoxContactoAlterar.Text = "";
            comboBoxMoradaAlterar.Text = "";
            textBoxNomeAlterar.Enabled = false;
            textBoxNifAlterar.Enabled = false;
            textBoxContactoAlterar.Enabled = false;
            comboBoxMoradaAlterar.Enabled = false;
            buttonCancelarAtua.Enabled = false;
            buttonGuardarAlteracoes.Enabled = false;
            listBoxNomeClientes.Enabled = true;
        }

        private void listBoxNomeClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxNomeClientes.SelectedItem;
            if (clienteSelecionado == null)
            {
                labelNomeCliente.Text = "";
                labelNifCliente.Text = "";
                labelMoradaCliente.Text = "";
                labelContactoCliente.Text = "";
                return;
            }
            else
            {
                labelNomeCliente.Text = clienteSelecionado.Nome;
                labelNifCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;
                labelContactoCliente.Text = clienteSelecionado.Contacto;
            }
        }

        private void buttonGuardarAlteracoes_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxNomeClientes.SelectedItem;

            clienteSelecionado.Nome = textBoxNomeAlterar.Text;
            clienteSelecionado.NIF = textBoxNifAlterar.Text;
            clienteSelecionado.Morada = comboBoxMoradaAlterar.Text;
            clienteSelecionado.Contacto = textBoxContactoAlterar.Text;

            meuStand.SaveChanges();
            listBoxNomeClientes.DataSource = null;
            CarregarDadosCliente();

            textBoxNomeAlterar.Text = "";
            textBoxNifAlterar.Text = "";
            textBoxContactoAlterar.Text = "";
            comboBoxMoradaAlterar.Text = "";
            textBoxNomeAlterar.Enabled = false;
            textBoxNifAlterar.Enabled = false;
            textBoxContactoAlterar.Enabled = false;
            comboBoxMoradaAlterar.Enabled = false;
            buttonCancelarAtua.Enabled = false;
            buttonGuardarAlteracoes.Enabled = false;
            listBoxNomeClientes.Enabled = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNifCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMorada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMoradaAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNifAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContactoAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void labelContactoCliente_Click(object sender, EventArgs e)
        {

        }

        private void labelMoradaCliente_Click(object sender, EventArgs e)
        {

        }

        private void labelNifCliente_Click(object sender, EventArgs e)
        {

        }

        private void labelNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
