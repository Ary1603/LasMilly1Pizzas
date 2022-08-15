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
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();



        }

        int pizzass;

        private void button1_Click(object sender, EventArgs e)
        {
            double pizzaChica = Convert.ToInt32(pizzaCH.Value);
            int pizzaMediana = Convert.ToInt32(pizzaM.Value);
            int pizzaGrande = Convert.ToInt32(pizzaG.Value);
            int pizzaExtraGrande = Convert.ToInt32(pizzaEG.Value);
            int pepinillos = Convert.ToInt32(IngPepinillos.Value);
            int jamon = Convert.ToInt32(IngJamon.Value);
            int pinia = Convert.ToInt32(IngPinia.Value);
            int salchicha = Convert.ToInt32(IngSalchicha.Value);
            int chorizo = Convert.ToInt32(IngChorizo.Value);
            int salami = Convert.ToInt32(IngSalami.Value);
            int champiniones = Convert.ToInt32(IngChampiniones.Value);
            int cebolla = Convert.ToInt32(IngCebolla.Value);


            double precio_tam_Pizza = (pizzaChica * 78) + (pizzaMediana * 150) + (pizzaGrande * 198) + (pizzaExtraGrande * 250);
            double sum_total_inge = (pepinillos + jamon + pinia + salchicha + chorizo + salami + champiniones + cebolla) * .10;
            double precio_ing_extra = precio_tam_Pizza * sum_total_inge;
            double precio_pizza = ((precio_tam_Pizza + precio_ing_extra) * .15) + precio_tam_Pizza + precio_ing_extra;

            

            Form menuP = new MenuP();
            //Form menuBP = new menuBP();
            menuP.MdiParent = this.ParentForm;
            this.Hide();


            List<string> Pizzas = new List<string>();

            if(pizzaChica > 0)
            {
                Pizzas.Add("Pizza Chica #"+ pizzaChica + ": $"  + Convert.ToString(pizzaChica * 78));
            }

            if(pizzaMediana > 0)
            {
                Pizzas.Add("Pizza Mediana #" + pizzaMediana + ": $" + Convert.ToString(pizzaMediana * 150));
            }

            if(pizzaGrande > 0)
            {
                Pizzas.Add("Pizza Grande #" + pizzaGrande + ": $" + Convert.ToString(pizzaGrande * 198));
            }

            if(pizzaExtraGrande > 0)
            {
                Pizzas.Add("Pizza Extra Grande #" + pizzaExtraGrande + ": $" + Convert.ToString(pizzaExtraGrande * 250));
            }
            
            if(pepinillos > 0)
            {
                Pizzas.Add("Ing. Extra Pepinillos: " + Convert.ToString(pepinillos));
            }

            if(jamon > 0)
            {
                Pizzas.Add("Ing. Extra Jamón: " + Convert.ToString(jamon));
            }

            if(pinia > 0)
            {
                Pizzas.Add("Ing. Extra Piña: " + Convert.ToString(pinia));
            }

            if(salchicha > 0)
            {
                Pizzas.Add("Ing. Extra Salchica: " + Convert.ToString(salchicha));
            }

            if(chorizo > 0)
            {
                Pizzas.Add("Ing. Extra Choorizo: " + Convert.ToString(chorizo));
            }

            if(salami > 0)
            {
                Pizzas.Add("Ing. Extra Salami: " + Convert.ToString(salami));
            }

            if(champiniones > 0)
            {
                Pizzas.Add("Ing. Extra Champiñones: " + Convert.ToString(champiniones));
            }

            if(cebolla > 0)
            {
                Pizzas.Add("Ing. Extra Cebolla: " + Convert.ToString(cebolla));
            }

            /*string toDisplay = string.Join(Environment.NewLine, Pizzas);
            MessageBox.Show(toDisplay, "Ticket");
            /*int count = Pizzas.Count();*/
            //MessageBox.Show("Precio: " + precio_pizza);





            using (menuBP frm1 = new menuBP(precio_pizza, Pizzas))
            {
                frm1.ShowDialog();
                
            }


        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form menuP = new MenuP();
            //Form menuBP = new menuBP();
            Form pagInfo = new pizzeriaInfo();
            menuP.MdiParent = this.ParentForm;
            this.Hide();
            pagInfo.Show();
        }
    }
}
