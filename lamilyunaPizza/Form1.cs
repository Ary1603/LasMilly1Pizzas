using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamilyunaPizza
{
    public partial class Inicio_P : Form
    {
        public Inicio_P()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form inicio = new Inicio_P();
            Form pedido = new MenuP();
            inicio.MdiParent = this.ParentForm;
            this.Hide();
            pedido.Show();
           
        }

        private void Inicio_P_Load(object sender, EventArgs e)
        {

        }
    }
}
