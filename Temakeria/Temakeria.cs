using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temakeria
{
    public partial class Temakeria : Form
    {
        public Temakeria()
        {
            InitializeComponent();
        }

        private void oPCOESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFuncionario addFun = new addFuncionario();
            addFun.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Temakeria_Load(object sender, EventArgs e)
        {

        }
    }
}
