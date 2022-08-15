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
    public partial class pizzeriaInfo : Form
    {
        public pizzeriaInfo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Form menuP = new MenuP();
            Form pagInfo = new pizzeriaInfo();
            pagInfo.MdiParent = this.ParentForm;
            this.Hide();
            menuP.Show();
        }
    }
}
