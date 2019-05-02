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
    public partial class Form1 : Form
    {
        private BaseDadosRealStandContainer meuStand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            meuStand = new BaseDadosRealStandContainer();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            GestaoCliente novoGestao = new GestaoCliente();
            novoGestao.Show();
        }

        private void buttonGestaoCarroOficina_Click(object sender, EventArgs e)
        {
            GestaoCarroOficina novoOficina = new GestaoCarroOficina();
            novoOficina.Show();
        }
    }
}
