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
    public partial class menuBP : Form
    {
        private int valorEnForm2;
        private List<string> listaEnForm2;
        public menuBP(double valor, List<string> valor1)
        {
            InitializeComponent();
            this.listaEnForm2 = valor1;
            this.valorEnForm2 = Convert.ToInt32(valor);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form menuBP= new menuBP();
            Form pedido = new MenuP();
            //menuBP.MdiParent = this.ParentForm;
            this.Hide();
            pedido.Show();
            //MessageBox.Show(Convert.ToString(valorEnForm2));

            
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Bebidas
            int refrescos = Convert.ToInt32(bebRefrescos.Value) * 19;
            int piniaColada = Convert.ToInt32(bebPiniaColada.Value) * 54;
            int agua = Convert.ToInt32(bebAgua.Value) *15;
            int cerveza = Convert.ToInt32(bebCerveza.Value) * 39;
            int jugos = Convert.ToInt32(bebJugos.Value) * 19;
            int michelada = Convert.ToInt32(bebMicheladas.Value) * 39;
            int limonada = Convert.ToInt32(bebLimonada.Value) * 24;
            int vinia = Convert.ToInt32(bebVinia.Value) * 36;
            int naranjada = Convert.ToInt32(bebNaranjada.Value) * 24;
            int yarda = Convert.ToInt32(bebYarda.Value) * 78;
            int Conga = Convert.ToInt32(bebConga.Value) * 46;
            int mojito = Convert.ToInt32(bebMojito.Value) * 76;

            //Postres
            int flan = Convert.ToInt32(postreFlan.Value) * 39;
            int flanNapolitano = Convert.ToInt32(postreFlanNapolitano.Value) * 44;
            int duraznos = Convert.ToInt32(postreDuraznos.Value) * 39;
            int helado = Convert.ToInt32(postreHelado.Value) * 36;

            double precioBebidas = refrescos + piniaColada + agua + cerveza + jugos + michelada + limonada + vinia + naranjada + yarda + Conga + mojito;
            double precioPostres = flan + flanNapolitano + duraznos + helado;
            double precio_final_pedido = precioBebidas + precioPostres + valorEnForm2;

            if(refrescos > 0)
            {
                listaEnForm2.Add("Refrescos #" + Convert.ToString(bebRefrescos.Value) + ": $ " + refrescos);
            }

            if(piniaColada > 0)
            {
                listaEnForm2.Add("Piña colada #" + Convert.ToString(bebPiniaColada.Value) + ": $" + piniaColada);
            }

            if(agua > 0)
            {
                listaEnForm2.Add("Agua #" + Convert.ToString(bebAgua.Value) + ": $" + agua);
            }

            if(cerveza > 0)
            {
                listaEnForm2.Add("Cerveza #" + Convert.ToString(bebCerveza.Value) + ": $" + cerveza);
            }

            if(jugos > 0)
            {
                listaEnForm2.Add("Jugos #" + Convert.ToString(bebJugos.Value) + ": $" + jugos);
            }

            if(michelada > 0)
            {
                listaEnForm2.Add("Michelada #" + Convert.ToString(bebMicheladas.Value) + ": $" + michelada);
            }

            if(limonada > 0)
            {
                listaEnForm2.Add("Limonada #" + Convert.ToString(bebLimonada.Value) + ": $" + limonada);
            }

            if(vinia > 0)
            {
                listaEnForm2.Add("Viña #" + Convert.ToString(bebVinia.Value) + ": $" + vinia);
            }

            if(naranjada > 0)
            {
                listaEnForm2.Add("Naranjada #" + Convert.ToString(bebNaranjada.Value) + ": $" + naranjada);
            }

            if(yarda > 0)
            {
                listaEnForm2.Add("Yarda #" + Convert.ToString(bebYarda.Value) + ": $" + yarda);
            }

            if(Conga > 0)
            {
                listaEnForm2.Add("Conga #" + Convert.ToString(bebConga.Value) + ": $" + Conga);
            }

            if(mojito > 0)
            {
                listaEnForm2.Add("Mojito #" + Convert.ToString(bebMojito.Value) + ": $" + mojito);
            }

            if(flan > 0)
            {
                listaEnForm2.Add("Flan #" + Convert.ToString(postreFlan.Value) + ": $" + flan);
            }

            if(flanNapolitano > 0)
            {
                listaEnForm2.Add("Flan Napolitano #" + Convert.ToString(postreFlanNapolitano.Value) + ": $" + flanNapolitano);
            }

            if(duraznos > 0)
            {
                listaEnForm2.Add("Duraznos #" + Convert.ToString(postreDuraznos.Value) + ": $" + duraznos);
            }

            if(helado > 0)
            {
                listaEnForm2.Add("Helado #" + Convert.ToString(postreHelado.Value) + ": $" + helado);
            }

            string toDisplay = string.Join(Environment.NewLine, listaEnForm2);
            DialogResult dialogResult = MessageBox.Show("Pedido: \n" + toDisplay + "\n Total: $" + precio_final_pedido + "\n *Nota: Los Ingredientes extra cuestan 10% el valor de la pizza", "Ticket",MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por su compra en breve estara listo su pedido", "Confirmación");
            }
            //MessageBox.Show("El precio final es: "+Convert.ToString(precio_final_pedido));
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form menuBP = new menuBP( valorEnForm2,  listaEnForm2);
            //Form menuBP = new menuBP();
            Form pagInfo = new pizzeriaInfo();
            menuBP.MdiParent = this.ParentForm;
            this.Hide();
            pagInfo.Show();
        }
    }
}
